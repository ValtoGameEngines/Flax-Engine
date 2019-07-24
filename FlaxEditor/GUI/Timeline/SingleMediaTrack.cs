// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.GUI.Timeline
{
    /// <summary>
    /// The base class for timeline tracks that use single media.
    /// </summary>
    /// <typeparam name="TMedia">The type of the media.</typeparam>
    /// <seealso cref="FlaxEditor.GUI.Timeline.Track" />
    public abstract class SingleMediaTrack<TMedia> : Track
    where TMedia : Media, new()
    {
        /// <summary>
        /// Gets the track media.
        /// </summary>
        public TMedia TrackMedia
        {
            get
            {
                TMedia media;
                if (Media.Count == 0)
                {
                    media = new TMedia
                    {
                        StartFrame = 0,
                        DurationFrames = Timeline?.DurationFrames ?? 60,
                    };
                    AddMedia(media);
                }
                else
                {
                    media = (TMedia)Media[0];
                }
                return media;
            }
        }

        /// <inheritdoc />
        protected SingleMediaTrack(ref TrackCreateOptions options)
        : base(ref options)
        {
        }
    }
}
