namespace Byrniee.UnityLogging
{
    /// <summary>
    /// Logger factory abstraction for creating ILoggers.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Creates the logger.
        /// </summary>
        /// <typeparam name="T">The logger type.</typeparam>
        /// <returns>The logger.</returns>
        ILogger<T> Create<T>();
    }
}
