// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Protocols.Contracts
{
    /// <summary>
    /// Represents a factory capable of resolving and instantiating implementations of an <see cref="ICtiProvider"/> contract.
    /// </summary>
    public interface ICtiProviderFactory
    {
        /// <summary>
        /// Discovers and instantiates an implementation of the provided <typeparamref name="THandler"/> contract with an optional <paramref name="name"/>.
        /// </summary>
        /// <typeparam name="THandler">The Request Handler contract to discover and instantiate.</typeparam>
        /// <param name="name">An optional contract name.</param>
        /// <returns>An implementation of the provided <typeparamref name="THandler"/> contract, if it exists.</returns>
        THandler Resolve<THandler>(string name = "")
            where THandler : ICtiProvider;
    }
}
