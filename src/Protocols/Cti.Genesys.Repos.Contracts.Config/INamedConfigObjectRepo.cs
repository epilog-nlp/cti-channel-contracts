// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing retrieval methods for Genesys Config Server objects by name.
    /// </summary>
    /// <typeparam name="TCfgObject">The type of Genesys Config object to retrieve.</typeparam>
    public interface INamedConfigObjectRepo<TCfgObject> : IGenesysRepo
        where TCfgObject : INamedConfigObject
    {
        /// <summary>
        /// Retrieves a Config Server object by its <paramref name="name"/>.
        /// Throws an exception if multiple matches are found.
        /// </summary>
        /// <param name="name">The <see cref="INamedConfigObject.Name"/> of the Config Server object.</param>
        /// <returns>A Config Server object with the provided <paramref name="name"/>, if it exists.</returns>
        TCfgObject GetByName(string name);

        /// <summary>
        /// Retrieves all Config Server objects matching the provided <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The <see cref="INamedConfigObject.Name"/> of the Config Server objects.</param>
        /// <returns>A collection of all Config Server objects with the provided <paramref name="name"/>.</returns>
        IEnumerable<TCfgObject> GetAllByName(string name);
    }
}
