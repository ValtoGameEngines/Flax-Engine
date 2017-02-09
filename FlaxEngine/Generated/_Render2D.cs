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
		/// The interface to render fast two dimensional graphics.
		/// </summary>
		public static partial class Render2D
		{
			/// <summary>
			/// Fill rectangle area
			/// </summary>
			/// <param name="rect">Rectangle to fill</param>
			/// <param name="color">Color to use</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void FillRectangle(Rectangle rect, Color color, bool withAlpha = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_FillRectangle1(ref rect, ref color, withAlpha);
#endif
			}

			/// <summary>
			/// Fill rectangle area
			/// </summary>
			/// <param name="rect">Rectangle to fill</param>
			/// <param name="color0">Color to use for upper left vertex</param>
			/// <param name="color1">Color to use for upper right vertex</param>
			/// <param name="color2">Color to use for bottom right vertex</param>
			/// <param name="color3">Color to use for bottom left vertex</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void FillRectangle(Rectangle rect, Color color0, Color color1, Color color2, Color color3, bool withAlpha = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_FillRectangle2(ref rect, ref color0, ref color1, ref color2, ref color3, withAlpha);
#endif
			}

			/// <summary>
			/// Draw rectangle borders
			/// </summary>
			/// <param name="rect">Rectangle to draw</param>
			/// <param name="color">Color to use</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
			/// <param name="thickness">Lines thickness (in pixels)</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void DrawRectangle(Rectangle rect, Color color, bool withAlpha = false, float thickness = 1.0f) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_DrawRectangle(ref rect, ref color, withAlpha, thickness);
#endif
			}

			/// <summary>
			/// Draw texture
			/// </summary>
			/// <param name="t">Texture to draw</param>
			/// <param name="rect">Rectangle to draw</param>
			/// <param name="color">Color to use</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void DrawTexture(Texture t, Rectangle rect, Color color, bool withAlpha = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_DrawTexture(Object.GetUnmanagedPtr(t), ref rect, ref color, withAlpha);
#endif
			}

			/// <summary>
			/// Draw line
			/// </summary>
			/// <param name="p1">Start point</param>
			/// <param name="p2">End point</param>
			/// <param name="color">Color to use</param>
			/// <param name="thickness">Lines thickness (in pixels)</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void DrawLine(Vector2 p1, Vector2 p2, Color color, float thickness = 1.0f, bool withAlpha = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_DrawLine(ref p1, ref p2, ref color, thickness, withAlpha);
#endif
			}

			/// <summary>
			/// Draw Bezier curve
			/// </summary>
			/// <param name="p1">Start point</param>
			/// <param name="p2">First control point</param>
			/// <param name="p3">Second control point</param>
			/// <param name="p4">End point</param>
			/// <param name="color">Color to use</param>
			/// <param name="thickness">Lines thickness (in pixels)</param>
			/// <param name="withAlpha">True if use alpha blending, otherwise it will be disabled</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static void DrawBezier(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Color color, float thickness = 1.0f, bool withAlpha = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_DrawBezier(ref p1, ref p2, ref p3, ref p4, ref color, thickness, withAlpha);
#endif
			}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_FillRectangle1(ref Rectangle rect, ref Color color, bool withAlpha);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_FillRectangle2(ref Rectangle rect, ref Color color0, ref Color color1, ref Color color2, ref Color color3, bool withAlpha);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_DrawRectangle(ref Rectangle rect, ref Color color, bool withAlpha, float thickness);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_DrawTexture(IntPtr t, ref Rectangle rect, ref Color color, bool withAlpha);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_DrawLine(ref Vector2 p1, ref Vector2 p2, ref Color color, float thickness, bool withAlpha);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_DrawBezier(ref Vector2 p1, ref Vector2 p2, ref Vector2 p3, ref Vector2 p4, ref Color color, float thickness, bool withAlpha);
#endif
#endregion
	}
}

