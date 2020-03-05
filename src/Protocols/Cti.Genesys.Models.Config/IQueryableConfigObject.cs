// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config object that can be directly retrieved by querying the API.
    /// </summary>
    public interface IQueryableConfigObject : IConfigObject
    {
        /// <summary>
        /// The state of the Config Server object.
        /// </summary>
        bool? Enabled { get; set; }
    }
}
