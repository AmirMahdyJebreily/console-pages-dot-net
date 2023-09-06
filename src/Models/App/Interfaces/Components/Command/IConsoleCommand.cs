using System;

namespace ConsolePages
{
    public interface IConsoleCommand
    {
        public char CommandKey { get; }

        public (string, ConsoleColor?)[] CommandDetails { get; }

        public Action<DialogStream> ObeyCommand { get; }
    }
}
