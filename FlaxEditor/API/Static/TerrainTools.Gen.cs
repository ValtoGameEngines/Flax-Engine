// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;
using FlaxEngine;
using Object = FlaxEngine.Object;

namespace FlaxEditor
{
    /// <summary>
    /// Terrain tools for editor. Allows to create and modify terrain.
    /// </summary>
    public static partial class TerrainTools
    {
        /// <summary>
        /// Performs a raycast against this terrain collision shape. Returns the hit chunk.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="ray">The ray.</param>
        /// <param name="resultHitDistance">The raycast result hit position distance from the ray origin. Valid only if raycast hits anything.</param>
        /// <param name="resultPatchCoord">The raycast result hit terrain patch coordinates (x and z). Valid only if raycast hits anything.</param>
        /// <param name="resultChunkCoord">The raycast result hit terrain chunk coordinates (relative to the patch, x and z). Valid only if raycast hits anything.</param>
        /// <param name="maxDistance">The maximum distance the ray should check for collisions.</param>
        /// <returns>True if ray hits an object, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static bool RayCastChunk(Terrain terrain, Ray ray, out float resultHitDistance, out Int2 resultPatchCoord, out Int2 resultChunkCoord, float maxDistance = float.MaxValue)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_RayCastChunk(Object.GetUnmanagedPtr(terrain), ref ray, out resultHitDistance, out resultPatchCoord, out resultChunkCoord, maxDistance);
#endif
        }

        /// <summary>
        /// Serializes the terrain chunk data to JSON string.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z).</param>
        /// <returns>The serialized chunk data.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static string SerializePatch(Terrain terrain, ref Int2 patchCoord)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_SerializePatch(Object.GetUnmanagedPtr(terrain), ref patchCoord);
#endif
        }

        /// <summary>
        /// Deserializes the terrain chunk data from the JSON string.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z).</param>
        /// <param name="value">The JSON string with serialized patch data.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static void DeserializePatch(Terrain terrain, ref Int2 patchCoord, string value)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_DeserializePatch(Object.GetUnmanagedPtr(terrain), ref patchCoord, value);
#endif
        }

        /// <summary>
        /// Checks if a given ray hits any of the terrain patches sides to add a new patch there.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="ray">The ray to use for tracing (eg. mouse ray in world space).</param>
        /// <param name="patchCoord">The result patch coordinates (x and z). Valid only when method returns true.</param>
        /// <returns>True if result is valid, otherwise nothing to add there.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static bool TryGetPatchCoordToAdd(Terrain terrain, Ray ray, out Int2 patchCoord)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_TryGetPatchCoordToAdd(Object.GetUnmanagedPtr(terrain), ref ray, out patchCoord);
#endif
        }

        /// <summary>
        /// Initializes the patch heightmap and collision to the default flat level.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z) to initialize it.</param>
        /// <returns>True if failed, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static bool InitializePatch(Terrain terrain, ref Int2 patchCoord)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_InitializePatch(Object.GetUnmanagedPtr(terrain), ref patchCoord);
#endif
        }

        /// <summary>
        /// Modifies the terrain patch heightmap with the given samples.
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z) to modify it.</param>
        /// <param name="samples">The samples. The array length is size.X*size.Y.</param>
        /// <param name="offset">The offset from the first row and column of the heightmap data (offset destination x and z start position).</param>
        /// <param name="size">The size of the heightmap to modify (x and z). Amount of samples in each direction.</param>
        /// <returns>True if failed, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static bool ModifyHeightmap(Terrain terrain, ref Int2 patchCoord, IntPtr samples, ref Int2 offset, ref Int2 size)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_ModifyHeightmap(Object.GetUnmanagedPtr(terrain), ref patchCoord, samples, ref offset, ref size);
#endif
        }

        /// <summary>
        /// Gets the raw pointer to the heightmap data (cached internally by the c++ core in editor).
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z) to gather it.</param>
        /// <returns>The pointer to the array of floats with terrain patch heights data. Null if failed to gatehr the data.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static IntPtr GetHeightmapData(Terrain terrain, ref Int2 patchCoord)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_GetHeightmapData(Object.GetUnmanagedPtr(terrain), ref patchCoord);
#endif
        }

        /// <summary>
        /// Gets the raw pointer to the visibility mask data (cached internally by the c++ core in editor).
        /// </summary>
        /// <param name="terrain">The terrain.</param>
        /// <param name="patchCoord">The patch coordinates (x and z) to gather it.</param>
        /// <returns>The pointer to the array of floats with terrain patch visibility mask data. Null if failed to gatehr the data.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static IntPtr GetVisibilityMapData(Terrain terrain, ref Int2 patchCoord)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_GetVisibilityMapData(Object.GetUnmanagedPtr(terrain), ref patchCoord);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_RayCastChunk(IntPtr terrain, ref Ray ray, out float resultHitDistance, out Int2 resultPatchCoord, out Int2 resultChunkCoord, float maxDistance);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string Internal_SerializePatch(IntPtr terrain, ref Int2 patchCoord);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_DeserializePatch(IntPtr terrain, ref Int2 patchCoord, string value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_TryGetPatchCoordToAdd(IntPtr terrain, ref Ray ray, out Int2 patchCoord);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_InitializePatch(IntPtr terrain, ref Int2 patchCoord);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_ModifyHeightmap(IntPtr terrain, ref Int2 patchCoord, IntPtr samples, ref Int2 offset, ref Int2 size);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr Internal_GetHeightmapData(IntPtr terrain, ref Int2 patchCoord);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr Internal_GetVisibilityMapData(IntPtr terrain, ref Int2 patchCoord);
#endif

        #endregion
    }
}
