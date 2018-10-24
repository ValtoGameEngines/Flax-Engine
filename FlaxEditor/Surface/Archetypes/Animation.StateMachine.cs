// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using FlaxEditor.GUI;
using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.Surface.Archetypes
{
    public static partial class Animation
    {
        /// <summary>
        /// Customized <see cref="SurfaceNode" /> for the state machine output node.
        /// </summary>
        /// <seealso cref="FlaxEditor.Surface.SurfaceNode" />
        public class StateMachine : SurfaceNode
        {
            private IntValueBox _maxTransitionsPerUpdate;
            private CheckBox _reinitializeOnBecomingRelevant;
            private CheckBox _skipFirstUpdateTransition;

            /// <summary>
            /// Flag for editor UI updating. Used to skip value change events to prevent looping data flow.
            /// </summary>
            protected bool _isUpdatingUI;
            
            /// <summary>
            /// Gets or sets the node title text.
            /// </summary>
            public string StateMachineTitle
            {
                get => (string)Values[0];
                set
                {
                    if (!string.Equals(value, (string)Values[0], StringComparison.Ordinal))
                    {
                        SetValue(0, value);
                    }
                }
            }

            /// <summary>
            /// Gets the state machine entry node (surface node object).
            /// </summary>
            public StateMachineEntry StateMachineEntryNode
            {
                get
                {
                    var nodeId = (int)Values[1];
                    return (StateMachineEntry)Surface.FindNode((uint)nodeId);
                }
                private set
                {
                    int nodeId = value != null ? (int)value.ID : 0;
                    if (nodeId != (int)Values[1])
                    {
                        SetValue(1, nodeId);
                    }
                }
            }

            /// <summary>
            /// Gets or sets the maximum amount of active transitions per update.
            /// </summary>
            public int MaxTransitionsPerUpdate
            {
                get => (int)Values[2];
                set => SetValue(2, value);
            }

            /// <summary>
            /// Gets or sets a value indicating whether reinitialize state machine on becoming relevant (used for blending, etc.).
            /// </summary>
            public bool ReinitializeOnBecomingRelevant
            {
                get => (bool)Values[3];
                set => SetValue(3, value);
            }

            /// <summary>
            /// Gets or sets a value indicating whether skip any triggered transitions durig first animation state machine update.
            /// </summary>
            public bool SkipFirstUpdateTransition
            {
                get => (bool)Values[4];
                set => SetValue(4, value);
            }
            
            /// <inheritdoc />
            public StateMachine(uint id, VisjectSurface surface, NodeArchetype nodeArch, GroupArchetype groupArch)
            : base(id, surface, nodeArch, groupArch)
            {
                var marginX = FlaxEditor.Surface.Constants.NodeMarginX;
                var uiStartPosY = FlaxEditor.Surface.Constants.NodeMarginY + FlaxEditor.Surface.Constants.NodeHeaderSize;

                var renameButton = new Button(marginX, uiStartPosY, 120, 20);
                renameButton.Text = "Rename";
                renameButton.Parent = this;
                renameButton.Clicked += StartRenaming;

                var editButton = new Button(renameButton.Right + 4, renameButton.Y, 120, 20);
                editButton.Text = "Edit";
                editButton.Parent = this;
                editButton.Clicked += Edit;

                var maxTransitionsPerUpdateLabel = new Label(marginX, renameButton.Bottom + 4, 153, TextBox.DefaultHeight);
                maxTransitionsPerUpdateLabel.HorizontalAlignment = TextAlignment.Near;
                maxTransitionsPerUpdateLabel.Text = "Max Transitions Per Update:";
                maxTransitionsPerUpdateLabel.Parent = this;

                _maxTransitionsPerUpdate = new IntValueBox(3, maxTransitionsPerUpdateLabel.Right + 4, maxTransitionsPerUpdateLabel.Y, 40, 1, 32, 0.1f);
                _maxTransitionsPerUpdate.ValueChanged += () => MaxTransitionsPerUpdate = _maxTransitionsPerUpdate.Value;
                _maxTransitionsPerUpdate.Parent = this;

                var reinitializeOnBecomingRelevantLabel = new Label(marginX, maxTransitionsPerUpdateLabel.Bottom + 4, 185, TextBox.DefaultHeight);
                reinitializeOnBecomingRelevantLabel.HorizontalAlignment = TextAlignment.Near;
                reinitializeOnBecomingRelevantLabel.Text = "Reinitialize On Becoming Relevant:";
                reinitializeOnBecomingRelevantLabel.Parent = this;

                _reinitializeOnBecomingRelevant = new CheckBox(reinitializeOnBecomingRelevantLabel.Right + 4, reinitializeOnBecomingRelevantLabel.Y, true, TextBox.DefaultHeight);
                _reinitializeOnBecomingRelevant.StateChanged += (checkbox) => ReinitializeOnBecomingRelevant = checkbox.Checked;
                _reinitializeOnBecomingRelevant.Parent = this;

                var skipFirstUpdateTransitionLabel = new Label(marginX, reinitializeOnBecomingRelevantLabel.Bottom + 4, 152, TextBox.DefaultHeight);
                skipFirstUpdateTransitionLabel.HorizontalAlignment = TextAlignment.Near;
                skipFirstUpdateTransitionLabel.Text = "Skip First Update Transition:";
                skipFirstUpdateTransitionLabel.Parent = this;

                _skipFirstUpdateTransition = new CheckBox(skipFirstUpdateTransitionLabel.Right + 4, skipFirstUpdateTransitionLabel.Y, true, TextBox.DefaultHeight);
                _skipFirstUpdateTransition.StateChanged += (checkbox) => SkipFirstUpdateTransition = checkbox.Checked;
                _skipFirstUpdateTransition.Parent = this;
            }

            /// <summary>
            /// Opens the state machine editing UI.
            /// </summary>
            public void Edit()
            {
                var entryNode = EnsureEntryNodeExists();

                // TODO: focus state machine
            }

            /// <summary>
            /// Starts the state machine renaming by showing a rename popup to the user.
            /// </summary>
            public void StartRenaming()
            {
                Surface.Select(this);
                var dialog = RenamePopup.Show(this, _headerRect, Title, false);
                dialog.Renamed += OnRenamed;
            }
            
            private void OnRenamed(RenamePopup renamePopup)
            {
                StateMachineTitle = renamePopup.Text;
            }

            /// <summary>
            /// Ensures the entry node of the state machine exists and has valid linkage to this node.
            /// </summary>
            /// <returns>The valid entry node.</returns>
            public SurfaceNode EnsureEntryNodeExists()
            {
                var entryNode = StateMachineEntryNode;
                if (entryNode == null)
                {
                    entryNode = (StateMachineEntry)Surface.SpawnNode(9, 19, BottomRight + new Vector2(10));
                    StateMachineEntryNode = entryNode;
                }

                return entryNode;
            }

            /// <summary>
            /// Updates the editor UI.
            /// </summary>
            protected void UpdateUI()
            {
                if (_isUpdatingUI)
                    return;
                _isUpdatingUI = true;

                _maxTransitionsPerUpdate.Value = MaxTransitionsPerUpdate;
                _reinitializeOnBecomingRelevant.Checked = ReinitializeOnBecomingRelevant;
                _skipFirstUpdateTransition.Checked = SkipFirstUpdateTransition;
                Title = StateMachineTitle;

                _isUpdatingUI = false;
            }

            /// <inheritdoc />
            public override void OnSurfaceLoaded()
            {
                base.OnSurfaceLoaded();

                EnsureEntryNodeExists();
                UpdateUI();
            }

            /// <inheritdoc />
            public override void SetValue(int index, object value)
            {
                base.SetValue(index, value);

                UpdateUI();
            }
        }
        
        /// <summary>
        /// Customized <see cref="SurfaceNode" /> for the state machine entry node.
        /// </summary>
        /// <seealso cref="FlaxEditor.Surface.SurfaceNode" />
        public class StateMachineEntry : SurfaceNode
        {
            /// <inheritdoc />
            public StateMachineEntry(uint id, VisjectSurface surface, NodeArchetype nodeArch, GroupArchetype groupArch)
            : base(id, surface, nodeArch, groupArch)
            {
            }
        }
    }
}
