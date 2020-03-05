// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server object exposed by an API.
    /// </summary>
    public interface IConfigObject : IGenesysObject
    {
        /// <summary>
        /// The DBID (Database Id) of the Config Server object. New objects will have a <c>null</c> Dbid.
        /// </summary>
        int? Dbid { get; set; }

        /// <summary>
        /// The parent Tenant DBID of the Config Server object.
        /// </summary>
        int TenantDbid { get; set; }
    }
}
