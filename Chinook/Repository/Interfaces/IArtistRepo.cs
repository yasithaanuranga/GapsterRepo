using Chinook.Models;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Chinook.Repository.IBaseRepo&lt;Chinook.Models.Artist&gt;" />
     interface IArtistRepo : IBaseRepo<Artist>
    {
        /// <summary>
        /// Searches the name of the by.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        Task<IEnumerable<Artist>> SearchByName(string str);
    }
}
