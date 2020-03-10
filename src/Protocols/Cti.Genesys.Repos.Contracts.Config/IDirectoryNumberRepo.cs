// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations of Genesys Config Server Directory Number (DN) objects.
    /// </summary>
    public interface IDirectoryNumberRepo : IConfigObjectRepo<IDirectoryNumber>
    {
        /// <summary>
        /// Retrieves all Directory Number Config Server objects with the provided <paramref name="directoryNumber"/>. 
        /// </summary>
        /// <remarks>
        /// The <see cref="IDirectoryNumber.Number"/> property is only required to be unique across each Switch,
        /// so each result can be expected to reside on a different Switch.
        /// </remarks>
        /// <param name="directoryNumber">The <see cref="IDirectoryNumber.Number"/> to match on.</param>
        /// <returns>A collection of Directory Number objects matching the provided <paramref name="directoryNumber"/>.</returns>
        IEnumerable<IDirectoryNumber> GetByNumber(string directoryNumber);
    }
}
