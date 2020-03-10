// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on the 'Server' class of Genesys Config Server Application objects. 
    /// </summary>
    public interface IServerRepo : IConfigObjectRepo<IServer>, INamedConfigObjectRepo<IServer>
    {
    }
}
