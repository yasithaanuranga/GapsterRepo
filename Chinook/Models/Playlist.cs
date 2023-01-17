using System;
using System.Collections.Generic;

namespace Chinook.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Playlist
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Playlist"/> class.
        /// </summary>
        public Playlist()
        {
            Tracks = new HashSet<Track>();
        }

        /// <summary>
        /// Gets or sets the playlist identifier.
        /// </summary>
        /// <value>
        /// The playlist identifier.
        /// </value>
        public long PlaylistId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the tracks.
        /// </summary>
        /// <value>
        /// The tracks.
        /// </value>
        public virtual ICollection<Track> Tracks { get; set; }
        /// <summary>
        /// Gets or sets the user playlists.
        /// </summary>
        /// <value>
        /// The user playlists.
        /// </value>
        public virtual ICollection<UserPlaylist> UserPlaylists { get; set; }
      //  public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
