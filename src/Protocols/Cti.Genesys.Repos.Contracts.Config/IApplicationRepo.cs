// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on Genesys Config Server Application objects.
    /// </summary>
    /// <remarks>
    /// While a Server is an Application object, this repository only exposes the common Application functionality.
    /// Use the dedicated <see cref="IServerRepo"/> to manage Server concerns.
    /// </remarks>
    public interface IApplicationRepo : IConfigObjectRepo<IApplication>, INamedConfigObjectRepo<IApplication>
    {
    }
}
