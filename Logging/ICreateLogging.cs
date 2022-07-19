using System;

namespace ProjectCollection.Logging
{
    public interface ICreateLogging
    {
        public void CreateLogs(Exception ex);
        public void CreateCustomLogs(string message, string logType);
    }
}
