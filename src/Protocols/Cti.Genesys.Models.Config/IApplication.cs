// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Config Server Application object.
    /// </summary>
    public interface IApplication : INamedConfigObject, IQueryableConfigObject
    {
        /// <summary>
        /// Identifier for the type of Application object.
        /// </summary>
        int AppType { get; set; }

        /// <summary>
        /// Connections to other Applications.
        /// </summary>
        IEnumerable<IConnectionInfo> AppServers { get; set; }
    }
}
