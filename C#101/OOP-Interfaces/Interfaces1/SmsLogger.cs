using System;

namespace OOPInterfaces {
    public class SmsLogger: ILogger {
        public void WriteLog()
        {
            Console.WriteLine("Write SMS logs.");
        }

    }
}