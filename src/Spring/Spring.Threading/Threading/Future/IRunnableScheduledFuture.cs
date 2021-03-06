namespace Spring.Threading.Future
{
    /// <summary> 
    /// A <see cref="IScheduledFuture{T}"/> that is a <see cref="IRunnable"/>. 
    /// </summary>
    /// <remarks>
    /// Successful execution of the <see cref="IRunnable.Run()"/> method causes 
    /// completion of the <see cref="IFuture{T}"/> and allows access to its results.
    /// </remarks>
    /// <seealso cref="FutureTask{T}"/>
    /// <seealso cref="IExecutor"/>
    /// <author>Doug Lea</author>
    /// <author>Griffin Caprio (.NET)</author>
    public interface IRunnableScheduledFuture<T> : IRunnableFuture<T>, IScheduledFuture<T>
    {
        /// <summary>
        /// Returns <c>true</c> if this is a periodic task. 
        /// </summary>
        /// <remarks>
        /// A periodic task may re-run according to some schedule. A non-periodic task can be
        /// run only once.
        /// </remarks>
        /// <returns><c>true</c> if this task is periodic, <c>false</c> otherwise.</returns>
        bool IsPeriodic { get; }
    }
}