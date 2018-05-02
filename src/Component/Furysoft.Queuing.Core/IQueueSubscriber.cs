// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueueSubscriber.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Queuing.Core
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    /// Interface for subscribing continuously to a queue
    /// </summary>
    public interface IQueueSubscriber
    {
        /// <summary>
        /// Gets a value indicating whether this instance is currently watching a queue
        /// </summary>
        bool IsRunning { get; }

        /// <summary>
        /// Ons the specified action.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="action">The action.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="IQueueSubscriber"/></returns>
        IQueueSubscriber On<TEntity>(
            [NotNull] Func<TEntity, CancellationToken, Task> action,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Starts the specified cancellation token.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        void Start(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}