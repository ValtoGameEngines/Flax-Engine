////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2018 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

namespace FlaxEngine
{
	public sealed partial class SpotLight
	{
	    /// <summary>
	    /// Gets the light scaled radius parameter.
	    /// </summary>
	    public float ScaledRadius => Scale.MaxValue * Radius;
	}
}
