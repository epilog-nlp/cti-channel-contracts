// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Repos.Config
{
    using Models.Config;

    /// <summary>
    /// Represents a repository exposing CRUD operations on Genesys Config Server Person objects.
    /// </summary>
    /// <remarks>
    /// While an Agent is a Person object, this repository only exposes the common Person functionality.
    /// Use the dedicated <see cref="IAgentRepo"/> to manage Agent concerns.
    /// </remarks>
    public interface IPersonRepo : IConfigObjectRepo<IPerson>, INamedConfigObjectRepo<IPerson>
    {
    }
}
