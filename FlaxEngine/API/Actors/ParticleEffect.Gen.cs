// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    /// <summary>
    /// The particle system instance that plays the particles simulation in the game.
    /// </summary>
    [Serializable]
    public sealed partial class ParticleEffect : Actor
    {
        /// <summary>
        /// Creates new <see cref="ParticleEffect"/> object.
        /// </summary>
        private ParticleEffect() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="ParticleEffect"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static ParticleEffect New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(ParticleEffect)) as ParticleEffect;
#endif
        }

        /// <summary>
        /// Gets or sets the particle system to play.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(0), Tooltip("The particle system to play.")]
        public ParticleSystem ParticleSystem
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetParticleSystem(unmanagedPtr); }
            set { Internal_SetParticleSystem(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
        }

        /// <summary>
        /// Gets or sets the particles simulation update mode. Defines how to update particles emitter.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(10), Tooltip("The particles simulation update mode. Defines how to update particles emitter.")]
        public SimulationUpdateMode UpdateMode
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetUpdateMode(unmanagedPtr); }
            set { Internal_SetUpdateMode(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the fixed timestep for simulation updates. Used only if UpdateMode is set to FixedTimestep.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(20), VisibleIf(nameof(IsFixedTimestep)), Tooltip("The fixed timestep for simulation updates. Used only if UpdateMode is set to FixedTimestep.")]
        public float FixedTimestep
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFixedTimestep(unmanagedPtr); }
            set { Internal_SetFixedTimestep(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the particles simulation speed factor. Scales the particle system update delta time. Can be used to speed up or slow down the particles.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(30), Tooltip("The particles simulation speed factor. Scales the particle system update delta time. Can be used to speed up or slow down the particles.")]
        public float SimulationSpeed
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetSimulationSpeed(unmanagedPtr); }
            set { Internal_SetSimulationSpeed(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the global time scale usage for particle simulation. Determines whether the particle effect should take into account the global game time scale for simulation updates.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(40), Tooltip("Determines whether the particle effect should take into account the global game time scale for simulation updates.")]
        public bool UseTimeScale
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetUseTimeScale(unmanagedPtr); }
            set { Internal_SetUseTimeScale(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the particle system play mode looping. Determines whether the particle effect should loop when it finishes playing.
        /// </summary>
        [UnmanagedCall]
        [EditorDisplay("Particle Effect"), EditorOrder(50), Tooltip("Determines whether the particle effect should loop when it finishes playing.")]
        public bool IsLooping
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsLooping(unmanagedPtr); }
            set { Internal_SetIsLooping(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the current time position of the particle system timeline animation playback (in seconds).
        /// </summary>
        /// <remarks>
        /// Please not that setting time value does not perform proper reving operation but changes the current animation position (editing value might result in flickered update).
        /// </remarks>
        [UnmanagedCall]
        [NoSerialize, HideInEditor]
        public float Time
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetTime(unmanagedPtr); }
            set { Internal_SetTime(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets the custom render task used as a view information source (effect will use its render buffers and rendering resolution information for particles simulation).
        /// </summary>
        [UnmanagedCall]
        [NoSerialize, HideInEditor]
        public FlaxEngine.Rendering.RenderTask CustomViewRenderTask
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetCustomViewRenderTask(unmanagedPtr); }
            set { Internal_SetCustomViewRenderTask(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
        }

        /// <summary>
        /// Gets or sets the last game time when particle system was updated. Value 01 indicates no previous updates.
        /// </summary>
        [UnmanagedCall]
        [NoSerialize, HideInEditor]
        public float LastUpdateTime
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetLastUpdateTime(unmanagedPtr); }
            set { Internal_SetLastUpdateTime(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets the CPU particles count (total).
        /// </summary>
        [UnmanagedCall]
        public int CPUParticlesCount
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetCPUParticlesCount(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Resets the particles simulation state (clears the instance state data but preserves the instance parameters values).
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void ResetSimulation()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_ResetSimulation(unmanagedPtr);
#endif
        }

        /// <summary>
        /// Performs the full particles simulation update (postponed for the next particle manager update).
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void UpdateSimulation()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_UpdateSimulation(unmanagedPtr);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern ParticleSystem Internal_GetParticleSystem(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetParticleSystem(IntPtr obj, IntPtr val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern SimulationUpdateMode Internal_GetUpdateMode(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetUpdateMode(IntPtr obj, SimulationUpdateMode val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetFixedTimestep(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetFixedTimestep(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetSimulationSpeed(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSimulationSpeed(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetUseTimeScale(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetUseTimeScale(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsLooping(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetIsLooping(IntPtr obj, bool val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetTime(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetTime(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern FlaxEngine.Rendering.RenderTask Internal_GetCustomViewRenderTask(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetCustomViewRenderTask(IntPtr obj, IntPtr val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float Internal_GetLastUpdateTime(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetLastUpdateTime(IntPtr obj, float val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetCPUParticlesCount(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_ResetSimulation(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_UpdateSimulation(IntPtr obj);
#endif

        #endregion
    }
}
