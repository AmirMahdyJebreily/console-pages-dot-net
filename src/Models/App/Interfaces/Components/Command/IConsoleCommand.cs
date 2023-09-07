using System;

namespace ConsolePages
{
    public interface IConsoleCommand
    {
        char CommandKey { get; }

        (string, ConsoleColor)[] CommandDetails { get; }

        Action<DialogStream, CApp> CommandHandler { get; }
    }
}
