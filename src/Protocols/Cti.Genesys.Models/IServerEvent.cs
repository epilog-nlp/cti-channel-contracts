// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models
{
    /// <summary>
    /// Represents an Event received from a Genesys API.
    /// </summary>
    public interface IServerEvent : IGenesysObject
    {
        /// <summary>
        /// Name of the Genesys Event.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Identifier for the Genesys Event.
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Reference Id used to identify the Event.
        /// </summary>
        int ReferenceId { get; set; }
    }
}
