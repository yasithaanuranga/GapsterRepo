using Chinook.Models;
using System.Numerics;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IBaseRepo&lt;Chinook.Models.Playlist&gt;" />
    /// <seealso cref="Chinook.Repository.IBaseRepo&lt;Chinook.Models.Playlist&gt;" />
     interface IPlayListRepo : IBaseRepo<Playlist>
    {
        /// <summary>
        /// Lists all for user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Playlist>> ListAllForUserId(string userId);
        /// <summary>
        /// Gets the with other data for playlist identifier.
        /// </summary>
        /// <param name="PlaylistId">The playlist identifier.</param>
        /// <param name="CurrentUserId">The current user identifier.</param>
        /// <returns></returns>
        Task<Chinook.ClientModels.Playlist> GetWithOtherDataForPlaylistId(long PlaylistId, string CurrentUserId);

        /// <summary>
        /// Gets the with track.
        /// </summary>
        /// <param name="playlistId">The playlist identifier.</param>
        /// <returns></returns>
        Task<Playlist?> GetWithTrack(long playlistId);


    }
}
