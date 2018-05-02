// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueue.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Queuing.Core
{
    /// <summary>
    /// Interface Representing available operations for a specific queue.
    /// </summary>
    public interface IQueue
    {
        /// <summary>
        /// Gets the queue pump.
        /// </summary>
        IQueuePump QueuePump { get; }

        /// <summary>
        /// Gets the queue receiver.
        /// </summary>
        IQueueReceiver QueueReceiver { get; }

        /// <summary>
        /// Gets the queue submitter.
        /// </summary>
        IQueueSubmitter QueueSubmitter { get; }

        /// <summary>
        /// Gets the queue subscriber.
        /// </summary>
        IQueueSubscriber QueueSubscriber { get; }
    }
}