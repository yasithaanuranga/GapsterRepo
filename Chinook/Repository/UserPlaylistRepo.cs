using Chinook.Models;
using Chinook.Repository;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IUserPlaylistRepo" />
    public class UserPlaylistRepo : IUserPlaylistRepo
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ChinookContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPlaylistRepo"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public UserPlaylistRepo(IDbContextFactory<ChinookContext> dbFactory)
        {
            _dbContext = dbFactory.CreateDbContext();
        }

        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Create(UserPlaylist obj)
        {
            _dbContext.Add<UserPlaylist>(obj);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(UserPlaylist obj)
        {
            _dbContext.Remove<UserPlaylist>(obj);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task< UserPlaylist?> Get(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserPlaylist> Get(long playlistId, string userId)
        {
            return await _dbContext.UserPlaylists.Where(up => up.UserId == userId && up.PlaylistId == playlistId).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<UserPlaylist?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<UserPlaylist>> ListAll()
        {
           return await _dbContext.UserPlaylists.ToListAsync();
        }


        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void UpdateAsync(UserPlaylist obj)
        {
            throw new NotImplementedException();
        }
    }
}
