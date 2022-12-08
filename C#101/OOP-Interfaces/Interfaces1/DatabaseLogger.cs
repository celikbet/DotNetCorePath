using System;

namespace OOPInterfaces {
    public class DatabaseLogger: ILogger {
        
        public void WriteLog()
        {
            Console.WriteLine("Write logs into Database.");
        }

    }
}