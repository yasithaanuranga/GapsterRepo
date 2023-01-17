using Chinook.Models;
using Chinook.Repository;
using Microsoft.EntityFrameworkCore;

namespace Chinook.Repository
{
    /// <summary>
    ///   <br />
    /// </summary>
    /// <seealso cref="Chinook.Repository.IArtistRepo" />
    public class ArtistRepo : IArtistRepo
    {
        /// <summary>
        /// The database context
        /// </summary>
        private ChinookContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistRepo"/> class.
        /// </summary>
        /// <param name="dbFactory">The database factory.</param>
        public ArtistRepo(IDbContextFactory<ChinookContext> dbFactory)
        {
            _dbContext = dbFactory.CreateDbContext();
        }

        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Create(Artist obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(Artist obj)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<Artist?> Get(long id)
        {

            return await _dbContext.Artists.FirstOrDefaultAsync(a => a.ArtistId == id);


        }
        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public Task<Artist?> GetByName(string name)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Artist>> ListAll()
        {

            return await _dbContext.Artists.ToListAsync();

        }

        /// <summary>
        /// Searches the name of the by.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Artist>> SearchByName(string str)
        {
            return await _dbContext.Artists.Where(a => a.Name.ToLower().StartsWith(str.ToLower())).ToListAsync();
        }

        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void UpdateAsync(Artist obj)
        {
            throw new NotImplementedException();
        }
    }
}
