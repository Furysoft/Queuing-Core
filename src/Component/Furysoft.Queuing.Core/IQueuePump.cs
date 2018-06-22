// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueuePump.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Queuing.Core
{
    using System;
    using System.Threading;
    using JetBrains.Annotations;

    /// <summary>
    /// Pump for submitting queue messages
    /// </summary>
    public interface IQueuePump
    {
        /// <summary>
        /// Occurs when [batch submitted].
        /// </summary>
        event EventHandler<int> BatchSubmitted;

        /// <summary>
        /// Occurs when [buffer empty].
        /// </summary>
        event EventHandler BufferEmpty;

        /// <summary>
        /// Adds the message.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="message">The message.</param>
        void AddMessage<TEntity>([NotNull] TEntity message)
            where TEntity : class;

        /// <summary>
        /// Starts the Queue Pump.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        void Start(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Stops the queue pump.
        /// </summary>
        void Stop();
    }
}