using System;

namespace OOPInterfaces {
    public class LogManager {
        public ILogger _logger; // creates interfaces' instance reference

        public LogManager(ILogger logger) {
            _logger = logger;

        }

        public void WriteLog() {
            _logger.WriteLog();
        }


    }
}
