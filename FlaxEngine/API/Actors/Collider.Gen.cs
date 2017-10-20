////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
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
	/// A base class for all colliders.
	/// </summary>
	[Serializable]
	public abstract partial class Collider : Actor
	{
		/// <summary>
		/// Gets or sets the 'IsTrigger' flag.
		/// </summary>
		/// <remarks>
		/// A trigger doesn't register a collision with an incoming Rigidbody. Instead, it sends OnTriggerEnter, OnTriggerExit and OnTriggerStay message when a rigidbody enters or exits the trigger volume.
		/// </remarks>
		[UnmanagedCall]
		[EditorOrder(0), EditorDisplay("Collider"), Tooltip("Check if use collider shape to detect objects or turn if off to collide with others")]
		public bool IsTrigger
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetIsTrigger(unmanagedPtr); }
			set { Internal_SetIsTrigger(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the contact offset.
		/// </summary>
		/// <remarks>
		/// Colliders whose distance is less than the sum of their ContactOffset values will generate contacts. The contact offset must be positive. Contact offset allows the collision detection system to predictively enforce the contact constraint even when the objects are slightly separated.
		/// </remarks>
		[UnmanagedCall]
		[EditorOrder(1), Limit(0, 100), EditorDisplay("Collider"), Tooltip("Determinates distance for detecting contacts with other colliders.")]
		public float ContactOffset
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetContactOffset(unmanagedPtr); }
			set { Internal_SetContactOffset(unmanagedPtr, value); }
#endif
		}

		/// <summary>
		/// Gets or sets the physical material used by this collider.
		/// </summary>
		[UnmanagedCall]
		[EditorOrder(2), AssetReference(typeof(PhysicalMaterial), true), EditorDisplay("Collider"), Tooltip("The phuysical material used by this collider.")]
		public JsonAsset Material
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetMaterial(unmanagedPtr); }
			set { Internal_SetMaterial(unmanagedPtr, Object.GetUnmanagedPtr(value)); }
#endif
		}

		/// <summary>
		/// Gets the attached rigidbody.
		/// </summary>
		[UnmanagedCall]
		[HideInEditor]
		public RigidBody AttachedRigidBody
		{
#if UNIT_TEST_COMPILANT
			get; set;
#else
			get { return Internal_GetAttachedRigidBody(unmanagedPtr); }
#endif
		}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetIsTrigger(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetIsTrigger(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetContactOffset(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetContactOffset(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern JsonAsset Internal_GetMaterial(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetMaterial(IntPtr obj, IntPtr val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RigidBody Internal_GetAttachedRigidBody(IntPtr obj);
#endif
#endregion
	}
}

