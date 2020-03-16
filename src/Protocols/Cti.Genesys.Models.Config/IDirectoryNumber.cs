// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server DN object.
    /// </summary>
    public interface IDirectoryNumber : IConfigObject, IQueryableConfigObject
    {
        /// <summary>
        /// Directory Number. Must be unique accross the parent Switch.
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// The type of DN this represents.
        /// </summary>
        string DnType { get; }

        /// <summary>
        /// The DBID of the Switch where this DN resides.
        /// </summary>
        int? SwitchDbid { get; set; }
    }
}
