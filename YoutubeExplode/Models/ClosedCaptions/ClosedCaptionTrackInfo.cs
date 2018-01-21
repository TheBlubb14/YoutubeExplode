﻿using JetBrains.Annotations;
using YoutubeExplode.Internal;

namespace YoutubeExplode.Models.ClosedCaptions
{
    /// <summary>
    /// Metadata associated with a certain <see cref="ClosedCaptionTrack"/>.
    /// </summary>
    public class ClosedCaptionTrackInfo
    {
        /// <summary>
        /// Manifest URL of the associated track.
        /// </summary>
        [NotNull]
        public string Url { get; }

        /// <summary>
        /// Language of the associated track.
        /// </summary>
        [NotNull]
        public Language Language { get; }

        /// <summary>
        /// Whether the associated track was automatically generated.
        /// </summary>
        public bool IsAutoGenerated { get; }

        /// <summary />
        public ClosedCaptionTrackInfo(string url, Language language, bool isAutoGenerated)
        {
            Url = url.GuardNotNull(nameof(url));
            Language = language.GuardNotNull(nameof(language));
            IsAutoGenerated = isAutoGenerated;
        }

        /// <inheritdoc />
        public override string ToString() => $"{Language}";
    }
}