using System;

namespace TestingAppOOP
{
    class ConsoleLogWriter: ILogWriter
    {
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tInfo\t{message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tWarning\t{message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tError\t{message}");
        }
    }
}
