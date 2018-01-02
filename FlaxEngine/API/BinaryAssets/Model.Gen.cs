////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
	/// <summary>
	/// Model asset that contains model object made of meshes which can rendered on the GPU.
	/// </summary>
	public sealed partial class Model : BinaryAsset
	{
		/// <summary>
		/// Creates new <see cref="Model"/> object.
		/// </summary>
		private Model() : base()
		{
		}

		/// <summary>
		/// Gets amount of loaded model LODs.
		/// </summary>
		[UnmanagedCall]
		public int LoadedLODs
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetLoadedLODs(unmanagedPtr); }
#endif
		}

		/// <summary>
		/// Gets the model bounding box in local space (from LOD0).
		/// </summary>
		[UnmanagedCall]
		public BoundingBox Box
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { BoundingBox resultAsRef; Internal_GetBox(unmanagedPtr, out resultAsRef); return resultAsRef; }
#endif
		}

		/// <summary>
		/// Gets or sets the minimum screen size to draw model (the bottom limit). Used to cull small models. Set to 0 to disable this feature.
		/// </summary>
		[UnmanagedCall]
		public float MinScreenSize
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetMinScreenSize(unmanagedPtr); }
			set { Internal_SetMinScreenSize(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Saves asset to the file. Saved are model and mesh properties but not a vertex data. Supported only in Editor.
		/// </summary>
		/// <returns>True if cannot save data, otherwise false.</returns>
#if UNIT_TEST_COMPILANT
		[Obsolete("Unit tests, don't support methods calls.")]
#endif
		[UnmanagedCall]
		public bool Save() 
		{
#if UNIT_TEST_COMPILANT
			throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
			return Internal_Save(unmanagedPtr);
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetLoadedLODs(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_GetBox(IntPtr obj, out BoundingBox resultAsRef);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetMinScreenSize(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetMinScreenSize(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_Save(IntPtr obj);
#endif
#endregion
	}
}

