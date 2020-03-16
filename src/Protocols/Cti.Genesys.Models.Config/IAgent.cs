// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Cti.Models.Config
{
    /// <summary>
    /// A special <see cref="IPerson"/> with Agent functionality.
    /// </summary>
    public interface IAgent : IPerson
    {
        /// <summary>
        /// DBID of the default Place object assigned to the Agent.
        /// </summary>
        int? DefaultPlaceDbid { get; set; }

        /// <summary>
        /// DBID of the Capacity Rule assigned to the Agent.
        /// </summary>
        int? CapacityRuleDbid { get; set; }

        /// <summary>
        /// DBID of the Contract assigned to the Agent.
        /// </summary>
        int? ContractDbid { get; set; }

        /// <summary>
        /// The Agent Logins assigned to this Agent.
        /// </summary>
        IEnumerable<IAgentLoginAssociation> Logins { get; set; }

        /// <summary>
        /// The Skills and associated proficiencies assigned to this Agent.
        /// </summary>
        IEnumerable<IAgentSkillLevel> Skills { get; set; }
    }

    /// <summary>
    /// Represents a Genesys Config Server association between Agent and Login.
    /// </summary>
    public interface IAgentLoginAssociation : IGenesysObject
    {
        /// <summary>
        /// DBID of the Agent Login object assigned to the Agent.
        /// </summary>
        int AgentLoginDbid { get; set; }

        /// <summary>
        /// Wrap-up time (seconds) associated with the Login Id.
        /// </summary>
        int WrapupTime { get; set; }
    }

    /// <summary>
    /// Represents an association between an Agent and a Skill.
    /// </summary>
    public interface IAgentSkillLevel : IGenesysObject
    {
        /// <summary>
        /// DBID of the associated Skill object.
        /// </summary>
        int SkillDbid { get; set; }

        /// <summary>
        /// The level of proficiency in the Skill.
        /// </summary>
        int Level { get; set; }
    }
}
