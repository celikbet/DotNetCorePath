using System;

namespace OOPInterfaces {
    public class Program {

        static void Main(string[] args) 
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            // Directly calling by LogManager.cs
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}

