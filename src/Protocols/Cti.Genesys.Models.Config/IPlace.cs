// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server Place object.
    /// </summary>
    public interface IPlace : INamedConfigObject, IQueryableConfigObject
    {
        /// <summary>
        /// DBIDs of DNs operated by the Place object.
        /// </summary>
        IEnumerable<int> DnDbids { get; set; }
    }
}
