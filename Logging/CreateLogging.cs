using Microsoft.Extensions.Logging;
using System;
namespace ProjectCollection.Logging
{
    class CreateLogging : ICreateLogging
    {
        private readonly ILogger _logger;
        public CreateLogging(ILogger<CreateLogging> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Creats the log with the exception
        /// </summary>
        /// <param name="ex">Exception from error</param>
        public void CreateLogs(Exception ex)
        {
            _logger.LogInformation("New Error");
            _logger.LogError(Convert.ToString(ex + "\r\n"));
        }
        /// <summary>
        /// Creats a Log with a custom message instead of an error
        /// </summary>
        /// <param name="message">Message thats gonna be written</param>
        /// <param name="logType">Type of message</param>
        public void CreateCustomLogs(string message, string logType)
        {
            switch (logType)
            {
                case "Information":
                    _logger.LogInformation(message + "\r\n");
                    break;
                case "Warning":
                    _logger.LogWarning(message + "\r\n");
                    break;
                case "Debug":
                    _logger.LogDebug(message + "\r\n");
                    break;
                case "Error":
                    _logger.LogError(message + "\r\n");
                    break;
                default:
                    _logger.LogError("Unknown logType\r\n");
                    break;
            }
        }
    }
}
