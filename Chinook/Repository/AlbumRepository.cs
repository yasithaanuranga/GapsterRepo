using Chinook.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

/// <summary>
/// 
/// </summary>
namespace Chinook.Repository
{
    /// <summary>
    ///   <br />
    /// </summary>
    /// <seealso cref="Chinook.Repository.IAlbumRepo" />
    public class AlbumRepository : IAlbumRepo
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ChinookContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumRepository" /> class.
        /// </summary>
        /// <param name="DbFactory">The database factory.</param>
        public AlbumRepository(IDbContextFactory<ChinookContext> DbFactory)
        {
            _dbContext = DbFactory.CreateDbContext();
        }


        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Create(Album obj)
        {
            _dbContext.Albums.Add(obj);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Delete(Album obj)
        {
            _dbContext.Albums.Remove(obj);
            _dbContext.SaveChangesAsync();

        }


        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<Album?> Get(long id)
        {
            return await _dbContext.Albums.FindAsync(id);
        }


        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<Album?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<IEnumerable<Album>> ListAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void UpdateAsync(Album obj)
        {
            _dbContext.Albums.Update(obj);
         
        }
    }
}
