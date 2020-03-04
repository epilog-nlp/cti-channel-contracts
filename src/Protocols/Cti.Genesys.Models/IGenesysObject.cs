// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models
{
    /// <summary>
    /// Represents an item exposed by a Genesys API.
    /// </summary>
    public interface IGenesysObject
    {
        /// <summary>
        /// The name of the object implementation.
        /// </summary>
        string TypeName { get; }
    }
}
