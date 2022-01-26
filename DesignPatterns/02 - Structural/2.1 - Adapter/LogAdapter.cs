using System;

namespace DesignPatterns
{
    // Adapter class
    public class LogAdapter : ILogger // ! Implemento a interface target
    {
        private readonly ILogNetMaster _logNetMaster; // ! injeto a interface adpater

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogInfo(message); 
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}