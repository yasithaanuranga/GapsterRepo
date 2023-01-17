using Chinook.Models;
using Chinook.Repository;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.ITrackRepo" />
    public class TrackRepo : ITrackRepo
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ChinookContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackRepo"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public TrackRepo(IDbContextFactory<ChinookContext> dbFactory)
        {
            _dbContext = dbFactory.CreateDbContext();

        }

        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Create(Track obj)
        {
            throw new NotImplementedException();
            
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Delete(Track obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Track?> Get(long id)
        {
            
               return await _dbContext.Tracks.Where(t => t.TrackId == id).Include(r=>r.Playlists).FirstOrDefaultAsync();
            
        }

        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Track>> ListAll()
        {
            
                return await _dbContext.Tracks.ToListAsync();
            
        }

        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void UpdateAsync(Track obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Lists all for artis.
        /// </summary>
        /// <param name="artistId">The artist identifier.</param>
        /// <returns></returns>
        async Task<IEnumerable<Track>> ITrackRepo.ListAllForArtis(long artistId)
        {
            return await _dbContext.Tracks.Where(a => a.Album.ArtistId == artistId).Include(a => a.Album).ThenInclude(a => a.Artist).ToListAsync();
        }

        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<Track?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Track?> GetTrackWithAllRelatedData(long trackId)
        {
            return await _dbContext.Tracks.Where(t => t.TrackId == trackId).Include(i=>i.Playlists).FirstOrDefaultAsync();
        }
    }
}
