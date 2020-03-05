// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// A special type of Config Server Application object with hosting details.
    /// </summary>
    public interface IServer : IApplication
    {
        /// <summary>
        /// The Host where the Server resides.
        /// </summary>
        int HostDbid { get; set; }

        /// <summary>
        /// The port exposing the Server.
        /// </summary>
        string Port { get; set; }

        /// <summary>
        /// Application defining the backup Server. Also a Server.
        /// </summary>
        int BackupServerDbid { get; set; }
    }
}
