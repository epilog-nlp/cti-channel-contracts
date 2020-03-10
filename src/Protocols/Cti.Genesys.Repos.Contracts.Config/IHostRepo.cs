// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD functionality on Genesys Config Server Host objects.
    /// </summary>
    public interface IHostRepo : IConfigObjectRepo<IHost>, INamedConfigObjectRepo<IHost>
    {
    }
}
