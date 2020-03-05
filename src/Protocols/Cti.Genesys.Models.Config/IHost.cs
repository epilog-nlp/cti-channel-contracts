// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server Host object.
    /// </summary>
    public interface IHost : INamedConfigObject, IQueryableConfigObject
    {
        /// <summary>
        /// IP Address of the Host.
        /// </summary>
        string IpAddress { get; set; }
    }
}
