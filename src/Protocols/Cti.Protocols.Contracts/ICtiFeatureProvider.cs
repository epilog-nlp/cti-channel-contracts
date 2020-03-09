// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Protocols.Contracts
{
    /// <summary>
    /// Represents a factory capable of resolving and instantiating implementations of an <see cref="ICtiFeature"/> contract.
    /// </summary>
    public interface ICtiFeatureProvider
    {
        /// <summary>
        /// Discovers and instantiates an implementation of the provided <typeparamref name="TFeature"/> contract with an optional <paramref name="name"/>.
        /// </summary>
        /// <typeparam name="TFeature">The CTI Feature contract to discover and instantiate.</typeparam>
        /// <param name="name">An optional contract name.</param>
        /// <returns>An implementation of the provided <typeparamref name="TFeature"/> contract, if it exists.</returns>
        TFeature Resolve<TFeature>(string name = "")
            where TFeature : ICtiFeature;
    }
}
