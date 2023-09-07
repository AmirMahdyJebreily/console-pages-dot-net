using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsolePages
{

    public class CommandSwitch : IDictionary<char, IConsoleCommand>
    {
        private Dictionary<char, IConsoleCommand> _commands = new Dictionary<char, IConsoleCommand>();
        public IConsoleCommand this[char key]
        {
            get => _commands[key];
            set => _commands[key] = value;
        }

        public CommandSwitch(char key, IConsoleCommand value)
        {
            _commands.Add(key, value);
        }

        public CommandSwitch(IConsoleCommand command)
        {
            _commands.Add(command.CommandKey, command);
        }

        public CommandSwitch(IConsoleCommand[] commands)
        {
            foreach (IConsoleCommand command in commands)
            {
                _commands.Add(command.CommandKey, command);
            }
        }

        public ICollection<char> Keys => _commands.Keys;

        public ICollection<IConsoleCommand> Values => _commands.Values;

        public int Count => _commands.Count;

        public bool IsReadOnly => false;

        public void Add(char key, IConsoleCommand value)
        {
            _commands.Add(key, value);
        }

        public void Add(char key, Action<DialogStream, CApp> obey, (string, ConsoleColor)[] details)
        {
            _commands.Add(key, new ConsoleCommand(key, obey, details));
        }

        public void Add(char key, Action<DialogStream, CApp> obey, params object[] details)
        {
            _commands.Add(key, ConsoleCommand.SetCommand(key, obey, details));
        }

        public void Add(KeyValuePair<char, IConsoleCommand> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _commands.Clear();
        }

        public bool Contains(KeyValuePair<char, IConsoleCommand> item) => _commands.ContainsKey(item.Key) && _commands.ContainsValue(item.Value);

        public bool ContainsKey(char key) => _commands.ContainsKey(key);

        public void CopyTo(KeyValuePair<char, IConsoleCommand>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<char, IConsoleCommand>> GetEnumerator() => _commands.GetEnumerator();

        public bool Remove(char key) => _commands.Remove(key);

        public bool Remove(KeyValuePair<char, IConsoleCommand> item) => Remove(item.Key);

        public bool TryGetValue(char key, out IConsoleCommand value) => _commands.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => _commands.GetEnumerator();
    }
}
