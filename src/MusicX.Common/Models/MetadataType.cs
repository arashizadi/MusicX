﻿namespace MusicX.Common.Models
{
    // Follow name convention in https://en.wikipedia.org/wiki/ID3
    public enum MetadataType : short
    {
        Title = 1,
        Artist = 2,

        // Information
        Genre = 11,

        // Additional Information
        Year = 101,

        // Album information
        AlbumName = 1001,

        // Images
        ImageUrl = 2001,

        // Lyrics
        Lyrics = 3001,

        // Playable media
        YouTubeVideoUrl = 10001,
    }
}
