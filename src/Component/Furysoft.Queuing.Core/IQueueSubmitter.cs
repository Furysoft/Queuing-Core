// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueueSubmitter.cs" company="Simon Paramore">
// © 2017, Simon Paramore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Furysoft.Queuing.Core
{
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    /// Interface for submitting single messages to a queue
    /// </summary>
    public interface IQueueSubmitter
    {
        /// <summary>
        /// Submits a message to the specified queue
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The <see cref="Task" />
        /// </returns>
        [ContractAnnotation("halt <= entity:null")]
        Task SubmitMessageAsync<TEntity>([NotNull] TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
    }
}