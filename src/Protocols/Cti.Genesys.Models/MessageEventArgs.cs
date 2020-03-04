// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models
{
    /// <summary>
    /// Event arguments used by an Event Handler subscribed to Genesys server Events.
    /// </summary>
    public class MessageEventArgs
    {
        /// <summary>
        /// The message received from the Genesys API.
        /// </summary>
        public IServerEvent Message { get; set; }
    }
}
