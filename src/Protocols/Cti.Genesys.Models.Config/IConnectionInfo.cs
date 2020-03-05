// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a link between two <see cref="IApplication"/> objects.
    /// </summary>
    public interface IConnectionInfo : IConfigObject
    {
        /// <summary>
        /// DBID of the connected <see cref="IApplication"/>.
        /// </summary>
        int AppServerDbid { get; set; }
    }
}
