﻿// Flax Engine scripting API

using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaxEngine.GUI
{
    /// <summary>
    /// GUI control that contains two child panels and the splitter between them.
    /// </summary>
    /// <seealso cref="FlaxEngine.GUI.ContainerControl" />
    public class SplitPanel : ContainerControl
    {
        /// <summary>
        /// The spliter size (in pixels).
        /// </summary>
        public const int SpliterSize = 4;

        private const int SpliterSizeHalf = SpliterSize / 2;

        private Orientation _orientation;
        private float _splitterValue;
        private Rectangle _splitterRect;
        private bool _splitterClicked, _mouseOverSplitter;

        /// <summary>
        /// The first panel (left or upper based on Orientation).
        /// </summary>
        public readonly Panel Panel1;

        /// <summary>
        /// The second panel.
        /// </summary>
        public readonly Panel Panel2;

        /// <summary>
        /// Gets the panel orientation.
        /// </summary>
        /// <value>
        /// The orientation.
        /// </value>
        public Orientation Orientation => _orientation;

        /// <summary>
        /// Gets or sets the splitter value (always in range [0; 1]).
        /// </summary>
        /// <value>
        /// The splitter value (always in range [0; 1]).
        /// </value>
        public float SplitterValue
        {
            get => _splitterValue;
            set
            {
                value = Mathf.Clamp01(value);
                if (!Mathf.NearEqual(_splitterValue, value))
                {

                    // Set new value
                    _splitterValue = value;

                    // Calculate rectangle and update panels
                    UpdateSplitRect();
                    PerformLayout();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitPanel"/> class.
        /// </summary>
        /// <param name="orientation">The orientation.</param>
        /// <param name="panel1Scroll">The panel1 scroll bars.</param>
        /// <param name="panel2Scroll">The panel2 scroll bars.</param>
        public SplitPanel(Orientation orientation = Orientation.Horizontal, ScrollBars panel1Scroll = ScrollBars.Both, ScrollBars panel2Scroll = ScrollBars.Both)
            : base(false)
        {
            _orientation = orientation;
            _splitterValue = 0.5f;
            DockStyle = DockStyle.Fill;

            Panel1 = new Panel(panel1Scroll);
            Panel2 = new Panel(panel2Scroll);

            Panel1.Parent = this;
            Panel2.Parent = this;

            UpdateSplitRect();
        }

        private void UpdateSplitRect()
        {
            if (_orientation == Orientation.Horizontal)
            {
                _splitterRect = new Rectangle(Mathf.Clamp(_splitterValue * Width - SpliterSizeHalf, 0.0f, Width), 0, SpliterSize, Height);
            }
            else
            {
                _splitterRect = new Rectangle(0, Mathf.Clamp(_splitterValue * Height - SpliterSizeHalf, 0.0f, Height), Width, SpliterSize);
            }
        }

        private void StartTracking()
        {
            // Start move
            _splitterClicked = true;

            // Start capturing mouse
            ParentWindow.StartTrackingMouse(false);
        }

        private void EndTracking()
        {
            if (_splitterClicked)
            {
                // Clear flag
                _splitterClicked = false;

                // End capturing mouse
                ParentWindow.EndTrackingMouse();
            }
        }

        /// <inheritdoc />
        public override bool HasMouseCapture => _splitterClicked || base.HasMouseCapture;

        /// <inheritdoc />
        public override void Draw()
        {
            base.Draw();

            // Draw splitter
            var style = Style.Current;
            Render2D.FillRectangle(_splitterRect, _splitterClicked ? style.BackgroundSelected : _mouseOverSplitter ? style.BackgroundHighlighted : style.LightBackground);
        }

        /// <inheritdoc />
        public override void OnLostFocus()
        {
            EndTracking();

            base.OnLostFocus();
        }

        /// <inheritdoc />
        public override void OnMouseMove(Vector2 location)
        {
            _mouseOverSplitter = _splitterRect.Contains(location);

            if (_splitterClicked)
            {
                SplitterValue = _orientation == Orientation.Horizontal ? location.X / Width : location.Y / Height;
            }

            base.OnMouseMove(location);
        }

        /// <inheritdoc />
        public override bool OnMouseDown(MouseButtons buttons, Vector2 location)
        {
            if (buttons == MouseButtons.Left)
            {
                if (_splitterRect.Contains(location))
                {
                    // Start moving splitter
                    StartTracking();
                    return false;
                }
            }

            return base.OnMouseDown(buttons, location);
        }

        /// <inheritdoc />
        public override bool OnMouseUp(MouseButtons buttons, Vector2 location)
        {
            if (_splitterClicked)
            {
                EndTracking();
                return true;
            }

            return base.OnMouseUp(buttons, location);
        }

        /// <inheritdoc />
        public override void OnMouseLeave()
        {
            // Clear flag
            _mouseOverSplitter = false;

            base.OnMouseLeave();
        }

        /// <inheritdoc />
        public override void OnLostMouseCapture()
        {
            EndTracking();
        }

        /// <inheritdoc />
        protected override void SetSizeInternal(Vector2 size)
        {
            base.SetSizeInternal(size);

            // Refresh
            UpdateSplitRect();
            PerformLayout();
        }

        /// <inheritdoc />
        protected override void PerformLayoutSelf()
        {
            if (_orientation == Orientation.Horizontal)
            {
                float split = Width * _splitterValue;

                Panel1.Bounds = new Rectangle(0, 0, split - SpliterSizeHalf, Height);
                Panel2.Bounds = new Rectangle(split + SpliterSizeHalf, 0, Width - split - SpliterSizeHalf, Height);
            }
            else
            {
                float split = Height * _splitterValue;

                Panel1.Bounds = new Rectangle(0, 0, Width, split - SpliterSizeHalf);
                Panel2.Bounds = new Rectangle(0, split + SpliterSizeHalf, Width, Height - split - SpliterSizeHalf);
            }
        }
    }
}
