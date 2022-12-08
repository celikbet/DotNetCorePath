using System;

namespace OOPInterfaces {
    public class FileLogger : ILogger {

        public void WriteLog()
        {
            Console.WriteLine("Write logs into file.");
        }

    }
}