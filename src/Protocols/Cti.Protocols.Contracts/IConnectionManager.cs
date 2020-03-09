// This source file is under MIT License (MIT).
// See the LICENSE file in the project root for more information.

using System;

namespace Cti.Protocols.Contracts
{
    /// <summary>
    /// Represents an object that can view and manage the state of a Protocol connection.
    /// </summary>
    public interface IConnectionManager : IRequestHandler
    {
        // TODO - Opened/Closed Events
        // TODO - State Indirection
        // TODO - Async

        /// <summary>
        /// Opens the connection, executing (optional) provided delegates on completion.
        /// </summary>
        /// <param name="onOpenDelegates">Delegates to invoke on completion.</param>
        void Open(params Action[] onOpenDelegates);

        /// <summary>
        /// Closes the connection, executing (optional) provided delegates on completion.
        /// </summary>
        /// <param name="onCloseDelegates">Delegates to invoke on completion.</param>
        void Close(params Action[] onCloseDelegates);
    }

    /// <summary>
    /// Represents an object that can view and manage the state of a <typeparamref name="TProvider"/> connection.
    /// </summary>
    /// <typeparam name="TProvider">The Provider whose connection to manage.</typeparam>
    public interface IConnectionManager<TProvider> : IConnectionManager, IRequestHandler<TProvider>
    {

    }
}
