using Microsoft.Extensions.Logging;
using System;
using static CoreService.Classes.Enumerations;

namespace CoreService.Classes.Error_Logging_System
{
    public class ErrorLogger
    {
        #region Private Variables

        private readonly ILogger _logger;

        #endregion
        #region Constructors

        public ErrorLogger(ILogger<ErrorLogger> logger)
        {
            _logger = logger;
        }

        #endregion
        #region Public Methods

        public bool Log(Exception ex)
        {
            return LogIssue(ex, string.Empty, ErrorLevel.Debug);
        }

        public bool Log(Exception ex, string customErrorMsg)
        {
            return LogIssue(ex, customErrorMsg, ErrorLevel.Debug);
        }

        public bool LogWarning(Exception ex)
        {
            return LogIssue(ex, string.Empty, ErrorLevel.Warning);
        }

        public bool LogWarning(Exception ex, string customErrorMsg)
        {
            return LogIssue(ex, customErrorMsg, ErrorLevel.Warning);
        }

        public bool LogError(Exception ex)
        {
            return LogIssue(ex, string.Empty, ErrorLevel.Error);
        }

        public bool LogError(Exception ex, string customErrorMsg)
        {
            return LogIssue(ex, customErrorMsg, ErrorLevel.Error);
        }

        public bool LogCritical(Exception ex)
        {
            return LogIssue(ex, string.Empty, ErrorLevel.CriticalError);
        }

        public bool LogCritical(Exception ex, string customErrorMsg)
        {
            return LogIssue(ex, customErrorMsg, ErrorLevel.CriticalError);

        }

        #endregion
        #region Private Methods

        private bool LogIssue(Exception ex, string customErrorMsg, ErrorLevel errLevel)
        {
            bool retval = false;

            try
            {
                if (!string.IsNullOrEmpty(customErrorMsg))
                    Console.WriteLine(errLevel.ToString() + ": " + customErrorMsg);

                Console.WriteLine(ex);
            }
            catch (Exception err)
            {
                Console.Write("ERROR: ErrorLogger failed to log an error.  How?!?!" + err.ToString());
            }

            return retval;
        }

        #endregion
    }
}
