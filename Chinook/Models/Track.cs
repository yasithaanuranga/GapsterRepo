using System;
using System.Collections.Generic;

namespace Chinook.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Track
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        public Track()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            Playlists = new HashSet<Playlist>();
        }

        /// <summary>
        /// Gets or sets the track identifier.
        /// </summary>
        /// <value>
        /// The track identifier.
        /// </value>
        public long TrackId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Gets or sets the album identifier.
        /// </summary>
        /// <value>
        /// The album identifier.
        /// </value>
        public long? AlbumId { get; set; }
        /// <summary>
        /// Gets or sets the media type identifier.
        /// </summary>
        /// <value>
        /// The media type identifier.
        /// </value>
        public long MediaTypeId { get; set; }
        /// <summary>
        /// Gets or sets the genre identifier.
        /// </summary>
        /// <value>
        /// The genre identifier.
        /// </value>
        public long? GenreId { get; set; }
        /// <summary>
        /// Gets or sets the composer.
        /// </summary>
        /// <value>
        /// The composer.
        /// </value>
        public string? Composer { get; set; }
        /// <summary>
        /// Gets or sets the milliseconds.
        /// </summary>
        /// <value>
        /// The milliseconds.
        /// </value>
        public long Milliseconds { get; set; }
        /// <summary>
        /// Gets or sets the bytes.
        /// </summary>
        /// <value>
        /// The bytes.
        /// </value>
        public long? Bytes { get; set; }
        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        public byte[] UnitPrice { get; set; } = null!;

        /// <summary>
        /// Gets or sets the album.
        /// </summary>
        /// <value>
        /// The album.
        /// </value>
        public virtual Album? Album { get; set; }
        /// <summary>
        /// Gets or sets the genre.
        /// </summary>
        /// <value>
        /// The genre.
        /// </value>
        public virtual Genre? Genre { get; set; }
        /// <summary>
        /// Gets or sets the type of the media.
        /// </summary>
        /// <value>
        /// The type of the media.
        /// </value>
        public virtual MediaType MediaType { get; set; } = null!;
        /// <summary>
        /// Gets or sets the invoice lines.
        /// </summary>
        /// <value>
        /// The invoice lines.
        /// </value>
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }

        /// <summary>
        /// Gets or sets the playlists.
        /// </summary>
        /// <value>
        /// The playlists.
        /// </value>
        public virtual ICollection<Playlist> Playlists { get; set; }
       // public virtual ICollection<PlaylistTrack > PlaylistTracks { get; set; }
    }
}
