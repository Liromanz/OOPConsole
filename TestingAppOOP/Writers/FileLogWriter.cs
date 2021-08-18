using System;
using System.IO;

namespace TestingAppOOP
{
    internal class FileLogWriter : ILogWriter
    {
        private readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt";
        internal FileLogWriter()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\log.txt");
        }
        public void LogInfo(string message)
        {
            using var file = new StreamWriter(path, true);
            file.WriteLineAsync($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tInfo\t{message}");
        }

        public void LogWarning(string message)
        {
            using var file = new StreamWriter(path, true);
            file.WriteLineAsync($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tWarning\t{message}");
        }

        public void LogError(string message)
        {
            using var file = new StreamWriter(path, true);
            file.WriteLineAsync($"{DateTime.Now:yyyy-MM-dd HH:mm:ss zzz}\tError\t{message}");
        }
    }
}
