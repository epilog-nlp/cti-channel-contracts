// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on Genesys Config Server objects.
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

        /// <summary>
        /// Creates the provided Config Server object and returns its value.
        /// </summary>
        /// <param name="itemToAdd">The item to add.</param>
        /// <returns>The created Config Server object, with all fields populated.</returns>
        TCfgObject Add(TCfgObject itemToAdd);

        /// <summary>
        /// Updates an existing Config Server object and returns its value.
        /// </summary>
        /// <param name="itemToUpdate">The existing item, with updated properties.</param>
        /// <returns>The updated Config Server object, with all fields populated.</returns>
        TCfgObject Update(TCfgObject itemToUpdate);

        /// <summary>
        /// Enables a Config Server object with the provided <paramref name="dbid"/>.
        /// </summary>
        /// <param name="dbid">The unique DBID of the Config Server object to enable.</param>
        /// <returns>The value of <see cref="IQueryableConfigObject.Enabled"/> after the operation.</returns>
        bool Enable(int dbid);

        /// <summary>
        /// Disables a Config Server object with the provided <paramref name="dbid"/>.
        /// </summary>
        /// <param name="dbid">The unique DBID of the Config Server object to disable.</param>
        /// <returns>The value of <see cref="IQueryableConfigObject.Enabled"/> after the operation.</returns>
        bool Disable(int dbid);
    }
}
