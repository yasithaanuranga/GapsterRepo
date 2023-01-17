using Chinook.Models;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IBaseRepo&lt;Chinook.Models.UserPlaylist&gt;" />
     interface IUserPlaylistRepo : IBaseRepo<UserPlaylist>
    {
        Task<UserPlaylist> Get(long playlistId, string UserId);
    }
}
