// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Models.Config
{
    /// <summary>
    /// Represents a Genesys Config Server Person object.
    /// </summary>
    public interface IPerson : INamedConfigObject, IQueryableConfigObject
    {
        /// <summary>
        /// The LDAP (or equivalent) Username associated with the Person. Used is <see cref="UsingExternalAuth"/> is enabled.
        /// </summary>
        string ExternalId { get; set; }

        /// <summary>
        /// The password used to login. Obviously, this can only be set.
        /// </summary>
        string Password { set; }

        /// <summary>
        /// Determines whether LDAP (or equivalent) integration should be used.
        /// </summary>
        bool? UsingExternalAuth { get; set; }

        /// <summary>
        /// The Person's first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// The Person's last name.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// The Person's email address.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// The DBID of the Folder location. When creating a new object, this must be set to the correct DBID of the target Folder.
        /// </summary>
        /// <remarks>
        /// If zero, the object will be saved under "Persons" (the default folder).
        /// </remarks>
        int? FolderId { get; set; }

        /// <summary>
        /// Full or partial CME object location path.
        /// </summary>
        /// <remarks>
        /// Required for Update.
        /// </remarks>
        string FolderPath { get; set; }

        /// <summary>
        /// Flag indicating the Person is an Agent. Can only be set on creation.
        /// </summary>
        bool IsAgent { get; set; }
    }
}
