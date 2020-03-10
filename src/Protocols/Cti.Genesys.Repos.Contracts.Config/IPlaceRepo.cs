// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on Genesys Config Server Place objects.
    /// </summary>
    public interface IPlaceRepo : IConfigObjectRepo<IPlace>, INamedConfigObjectRepo<IPlace>
    {
    }
}
