using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestingAppOOP
{
    class Program
    {
        static void Main()
        {
            var writers = new List<ILogWriter>
            {
                new FileLogWriter(),
                new ConsoleLogWriter()
            };

            var multipleLogWriter = new MultipleLogWriter(writers);
            multipleLogWriter.LogInfo("This is an info");
            multipleLogWriter.LogError("This is an error");
            multipleLogWriter.LogWarning("This is a warning");

            Process.Start(new ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt") { UseShellExecute = true });
            Console.ReadKey();
        }
    }
}
