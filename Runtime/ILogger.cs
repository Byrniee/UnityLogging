namespace Byrniee.UnityLogging
{
    /// <summary>
    /// Logging abstraction.
    /// </summary>
    /// <typeparam name="T">Log type.</typeparam>
    public interface ILogger<T>
    {
        /// <summary>
        /// Logs a message at trace level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogTrace(string message, params object[] args);

        /// <summary>
        /// Logs a message at debug level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogDebug(string message, params object[] args);
        
        /// <summary>
        /// Logs a message at information level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogInformation(string message, params object[] args);
        
        /// <summary>
        /// Logs a message at warning level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogWarning(string message, params object[] args);
        
        /// <summary>
        /// Logs a message at error level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogError(string message, params object[] args);
        
        /// <summary>
        /// Logs a message at critical level.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        void LogCritical(string message, params object[] args);
    }
}