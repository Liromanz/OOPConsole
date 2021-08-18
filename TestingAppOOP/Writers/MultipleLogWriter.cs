using System.Collections.Generic;

namespace TestingAppOOP
{
    internal class MultipleLogWriter : ILogWriter
    {
        private readonly IEnumerable<ILogWriter> _writers;
        internal MultipleLogWriter(IEnumerable<ILogWriter> writers) => _writers = writers;

        public void LogInfo(string message)
        {
            foreach (var writer in _writers)
                writer.LogInfo(message);
        }

        public void LogWarning(string message)
        {
            foreach (var writer in _writers)
                writer.LogWarning(message);
        }

        public void LogError(string message)
        {
            foreach (var writer in _writers)
                writer.LogError(message);
        }
    }
}
