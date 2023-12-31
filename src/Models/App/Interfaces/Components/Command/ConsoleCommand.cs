﻿using System;

namespace ConsolePages
{
    public class ConsoleCommand : IConsoleCommand
    {
        private char _commandKey;
        private Action<DialogStream> _obey;
        private (string, ConsoleColor)[] _details;

        public char CommandKey => _commandKey;
        public (string, ConsoleColor)[] CommandDetails => _details;
        public Action<DialogStream> CommandHandler => _obey;

        public void SetCommandDetails(params object[] details)
        {
            _details = _prvt_sttc._objArr2TCAPPF(details);
        }

        public ConsoleCommand(char keyChar, Action<DialogStream> inObey, (string, ConsoleColor)[] details)
        {
            _commandKey = keyChar;
            _obey = inObey;
            _details = details;
        }

        public static ConsoleCommand SetCommand(char keyChar, Action<DialogStream> inObey, params object[] details)
            => new ConsoleCommand(keyChar, inObey, _prvt_sttc._objArr2TCAPPF(details));
    }
}
