using Chinook.Models;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IBaseRepo&lt;Chinook.Models.Track&gt;" />
    interface ITrackRepo : IBaseRepo<Track>
    {
        /// <summary>
        /// Lists all for artis.
        /// </summary>
        /// <param name="artistId">The artist identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Track>> ListAllForArtis(long artistId);

        /// <summary>
        /// Gets the track with all related data.
        /// </summary>
        /// <param name="trackId">The track identifier.</param>
        /// <returns></returns>
        Task<Track?> GetTrackWithAllRelatedData(long trackId);
    }
}
