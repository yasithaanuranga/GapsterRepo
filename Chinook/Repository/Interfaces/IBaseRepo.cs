using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TObj">The type of the object.</typeparam>
    interface IBaseRepo<TObj>
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<TObj?> Get(long id);
        /// <summary>
        /// Creates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        void Create(TObj obj);
        /// <summary>
        /// Updates the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        void UpdateAsync(TObj obj);
        /// <summary>
        /// Deletes the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        void Delete(TObj obj);
        /// <summary>
        /// Lists all.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TObj>> ListAll();
        /// <summary>
        /// Gets the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        Task<TObj?> GetByName(String name);

    }
}
