// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on Genesys Config Server objects.
    /// </summary>
    /// <typeparam name="TCfgObject">The type of Config Server object.</typeparam>
    public interface IReadWriteConfigRepo<TCfgObject> : IConfigObjectRepo<TCfgObject>
        where TCfgObject : IQueryableConfigObject
    {
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
