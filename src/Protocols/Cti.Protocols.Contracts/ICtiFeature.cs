// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

namespace Cti.Protocols.Contracts
{
    /// <summary>
    /// Base type for all items that expose CTI functionality.
    /// Domain visible contracts will implement this interface, while the specialized implementations will use the generic version.
    /// </summary>
    public interface ICtiFeature
    {
        /// <summary>
        /// Name used to distinguish implementations sharing the same contract signature.
        /// </summary>
        string Name { get; }
    }

    /// <summary>
    /// Represents a Request Handler that delegates requests to a protocol of type <typeparamref name="TProvider"/>.
    /// </summary>
    /// <typeparam name="TProvider">The protocol capable of handling requests.</typeparam>
    public interface ICtiFeature<TProvider> : ICtiFeature
    {
        /// <summary>
        /// Creates an instance of this Request Handler using the provided <paramref name="protocol"/>.
        /// </summary>
        /// <param name="protocol">The provider this Request Handler delegates requests to.</param>
        /// <returns>An instance of this Request Handler, created using the provided <paramref name="protocol"/>.</returns>
        ICtiFeature Create(TProvider protocol);
    }
}
