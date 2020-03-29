// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing retrieval methods for Genesys Config Server objects by their unique DBID.
    /// </summary>
    /// <typeparam name="TCfgObject">The type of Config Server object.</typeparam>
    public interface IConfigObjectRepo<TCfgObject> : IGenesysRepo
        where TCfgObject : IQueryableConfigObject
    {
        /// <summary>
        /// Retrieves a Config Server object by its unique <paramref name="dbid"/>.
        /// </summary>
        /// <param name="dbid">The unique DBID of the object to retrieve.</param>
        /// <returns>The Config Server object with the provided <paramref name="dbid"/>, if it exists.</returns>
        TCfgObject Get(int dbid);

        /// <summary>
        /// Retrieves multiple Config Server objects by their unique <paramref name="dbids"/>.
        /// Retrieves all items if no <paramref name="dbids"/> are provided.
        /// </summary>
        /// <param name="dbids">A collection of unique DBIDs of the objects to retrieve.</param>
        /// <returns>A collection of Config Server objects matching the provided <paramref name="dbids"/>.</returns>
        IEnumerable<TCfgObject> Get(params int[] dbids);
    }
}
