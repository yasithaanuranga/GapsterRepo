using Chinook.Models;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IPlayListRepo" />
    public class PlayListRepo : IPlayListRepo
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ChinookContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayListRepo"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public PlayListRepo(IDbContextFactory<ChinookContext> dbFactory)
        {
            _dbContext = dbFactory.CreateDbContext();
        }
        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Create(Playlist obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChangesAsync();

        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public  void Delete(Playlist obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChangesAsync();
        }


        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Playlist?> Get(long id)
        {
            return await _dbContext.Playlists.Where(p => p.PlaylistId == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Playlist>> ListAll()
        {
            return await _dbContext.Playlists.Include(c => c.UserPlaylists).ToListAsync();
        }

        /// <summary>
        /// Lists all for user identifier.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Playlist>> ListAllForUserId(string userId)
        {
            return await _dbContext.Playlists.Include(c => c.UserPlaylists).Where(p => p.UserPlaylists.Any(s => s.UserId == userId)).ToListAsync();
        }

        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public  void UpdateAsync(Playlist obj)
        {
           
            _dbContext.Playlists.Update(obj);
            _dbContext.SaveChanges();

        }


        /// <summary>
        /// Gets the with other data for playlist identifier.
        /// </summary>
        /// <param name="PlaylistId">The playlist identifier.</param>
        /// <param name="CurrentUserId">The current user identifier.</param>
        /// <returns></returns>
        public async Task<Chinook.ClientModels.Playlist> GetWithOtherDataForPlaylistId(long PlaylistId, string CurrentUserId)
        {
            var res = await _dbContext.Playlists
            .Include(a => a.Tracks).ThenInclude(a => a.Album).ThenInclude(a => a.Artist)
            .Where(p => p.PlaylistId == PlaylistId)
            .Select(p => new ClientModels.Playlist()
            {
                Name = p.Name,
                Tracks = p.Tracks.Select(t => new ClientModels.PlaylistTrack()
                {
                    AlbumTitle = t.Album.Title,
                    ArtistName = t.Album.Artist.Name,
                    TrackId = t.TrackId,
                    TrackName = t.Name,
                    IsFavorite = t.Playlists.Where(p => p.UserPlaylists.Any(up => up.UserId == CurrentUserId && up.Playlist.Name == "Favorites")).Any()
                }).ToList()
            })
            .FirstOrDefaultAsync();

            return res;
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public async Task<Playlist?> GetByName(string name)
        {
            return await _dbContext.Playlists.Where(x => x.Name == name).FirstOrDefaultAsync();
        }

        public async Task<Playlist?> GetWithTrack(long playlistId)
        {
            return await _dbContext.Playlists.Include(a => a.Tracks).ThenInclude(a => a.Album).ThenInclude(a => a.Artist).Where(f => f.PlaylistId == playlistId).FirstOrDefaultAsync();
        }

    }
}
