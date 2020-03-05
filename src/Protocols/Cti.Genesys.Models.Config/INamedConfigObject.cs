// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server object with a name.
    /// </summary>
    public interface INamedConfigObject
    {
        /// <summary>
        /// Name of the Config Server object.
        /// </summary>
        string Name { get; set; }
    }
}
