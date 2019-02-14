using System;
using System.Collections.Generic;

namespace PlaylistsNET.Models
{
    public class M3uPlaylistEntry : BasePlaylistEntry
    {
        public M3uPlaylistEntry()
        {
            CustomTagValues = new Dictionary<string, string>();
        }

        public TimeSpan Duration { get; set; }
        public string Title { get; set; }
        public string Album { get; set; }
        public string AlbumArtist { get; set; }
        public Dictionary<string, string> CustomTagValues { get; set; }
    }
}
