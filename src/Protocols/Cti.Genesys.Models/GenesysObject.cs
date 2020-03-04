// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models
{
    /// <summary>
    /// An item exposed by a Genesys API.
    /// </summary>
    public abstract class GenesysObject : IGenesysObject
    {
        /// <summary>
        /// The name of the object implementation.
        /// </summary>
        public virtual string TypeName => GetType().Name;
    }
}
