using System;

namespace ConsolePages
{

    public class DialogStream
    {
        private Action<object> _print = _prvt_sttc._prnt_mtd;
        private Func<string> _input = _prvt_sttc._input_mtd;
        private Func<ConsoleKeyInfo> _command = _prvt_sttc._command_mtd;
        private Action<ConsoleColor> _ch_color = _prvt_sttc._chng_color_mtd;
        private Action _clear = _prvt_sttc._cln_mtd;
        private ColorTheme _theme = _prvt_sttc._dflt_color_theme;

        #region Print No Line Method
        public void PrintNl(object obj) => _print(obj);
        public void PrintNl(string text) => _print(text);
        public void PrintNl(string text, ConsoleColor color)
        {
            _ch_color(color);
            _print(text);
            _ch_color(_theme.PrimeryColor);

        }
        public void PrintNl(string sep = "\u0020", params string[] texts) => PrintNl(string.Join(sep, texts));
        public void PrintNl(params string[] texts) => PrintNl(string.Join("\u0020", texts));
        public void PrintNl(string sep = "\u0020", params (string, ConsoleColor?)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i].Item2 == null)
                {
                    _ch_color(_theme.PrimeryColor);
                }
                else
                {
                    _ch_color(texts[i].Item2.Value);
                }
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl(sep); // add seprator to texts
                }

            }
        }
        public void PrintNl(params (string, ConsoleColor?)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i].Item2 == null)
                {
                    _ch_color(_theme.PrimeryColor);
                }
                else
                {
                    _ch_color(texts[i].Item2.Value);
                }
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl("\u0020"); // add seprator to texts
                }

            }
        }
        public void PrintNl(params object[] items)
        {
            (string, ConsoleColor?)[] res = new (string, ConsoleColor?)[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                string strValue = string.Empty;
                ConsoleColor? color = null;

                var item = items[i];

                if (item.GetType() == typeof((string, ConsoleColor)))
                {
                    strValue = (((string, ConsoleColor))item).Item1;
                    color = (((string, ConsoleColor))item).Item2;
                }
                else
                {
                    strValue = items[i].ToString();
                }

                res[i] = (strValue, color);
            }
            PrintNl(res);
        }
        #endregion

        #region Print Method
        public void Print(object obj) => PrintNl(sep: "", obj.ToString(), "\n");
        public void Print(string text) => PrintNl(sep: "", text, "\n");
        public void Print(string text, ConsoleColor color)
        {
            _ch_color(color);
            PrintNl(text, "\n");
            _ch_color(_theme.PrimeryColor);

        }
        public void Print(string[] texts, string sep = "\n") => PrintNl(string.Join(sep, texts));
        public void Print(params string[] texts) => PrintNl(string.Join("\n", texts) + "\n");

        public void Print((string, ConsoleColor?)[] texts, string sep = "\n")
        {
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i].Item2 == null)
                {
                    _ch_color(_theme.PrimeryColor);
                }
                else
                {
                    _ch_color(texts[i].Item2.Value);
                }
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl(sep); // add seprator to texts
                }
            }
            PrintNl("\n");
        }

        public void Print(params (string, ConsoleColor?)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i].Item2 == null)
                {
                    _ch_color(_theme.PrimeryColor);
                }
                else
                {
                    _ch_color(texts[i].Item2.Value);
                }
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl("\u0020"); // add seprator to texts
                }

            }
            PrintNl('\n');
        }
        public void Print(params object[] items)
        {
            var res = _prvt_sttc._objArr2TCAPPF(items);
            Print(res);
        }
        #endregion

        #region Input Method
        public string Input() => _input();

        public string Input(object obj)
        {
            PrintNl(obj.ToString());
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(string text)
        {
            PrintNl(text.ToString());
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(string text, ConsoleColor color)
        {
            PrintNl(text, color);
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(string sep = "\u0020", params string[] texts)
        {
            PrintNl(sep, texts);
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(params string[] texts)
        {
            PrintNl(texts);
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(string sep = "\u0020", params (string, ConsoleColor?)[] texts)
        {
            PrintNl(sep, texts);
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(params (string, ConsoleColor?)[] texts)
        {
            PrintNl(texts);
            _ch_color(InputColor);
            string res = _input();
            ResetColor();
            return res;
        }
        public string Input(params object[] items)
        {
            PrintNl(items);
            _ch_color(InputColor);
            return Input();
        }

        #endregion

        #region Command Method
        public char GetCommand()
        {
            return _command().KeyChar;
        }

        private void _printCommandDetail(CommandSwitch commands)
        {
            foreach (var item in commands.Values)
            {
                PrintNl($"\t[{item.CommandKey}] ", InfoColor);
                Print(item.CommandDetails);
            }
        }

        public ConsoleCommand MakeCommand(char key, Action<DialogStream, CApp> handler, params object[] details)
        {
            return ConsoleCommand.SetCommand(key, handler, details);
        }

        public ConsoleCommand MakeCommand(char key, Action<DialogStream> handler, params object[] details)
        {
            return ConsoleCommand.SetCommand(key, (a, c) => handler(a), details);
        }

        public ConsoleCommand MakeCommand(char key, Action<CApp> handler, params object[] details)
        {
            return ConsoleCommand.SetCommand(key, (a, c) => handler(c), details);
        }

        public ConsoleCommand MakeCommand(char key, Action handler, params object[] details)
        {
            return ConsoleCommand.SetCommand(key, (a, c) => handler(), details);
        }

        public void GetCommand(CApp cApp, CommandSwitch consoleCommands)
        {
            _printCommandDetail(consoleCommands);
            char key = _command().KeyChar;
            consoleCommands[key].CommandHandler.Invoke(new DialogStream(), cApp);
        }

        public void GetCommand(CApp cApp, ConsoleCommand[] consoleCommands)
        {
            var _switch = new CommandSwitch(consoleCommands);
            _printCommandDetail(_switch);
            char key = _command().KeyChar;
            _switch[key].CommandHandler.Invoke(new DialogStream(), cApp);
        }

        public void GetCommand(ConsoleCommand[] consoleCommands)
        {
            var _switch = new CommandSwitch(consoleCommands);
            _printCommandDetail(_switch);
            char key = _command().KeyChar;
            _switch[key].CommandHandler.Invoke(null, null);
        }

        #endregion

        public void WaitForAnyKey()
        {
            _command();
        }

        public void End()
        {
            Print("Enter any key to return ...");
            WaitForAnyKey();
        }

        public Action Clear => _clear;

        #region Colors of Theme
        public ColorTheme Theme => _theme;

        public ConsoleColor PrimeColor => _theme.PrimeryColor;
        public ConsoleColor SecondColor => _theme.SecondColor;
        public ConsoleColor WarningColor => _theme.WarningColor;
        public ConsoleColor ErrorColor => _theme.ErrorColor;
        public ConsoleColor SuccessColor => _theme.SuccessColor;
        public ConsoleColor InfoColor => _theme.InformationColor;
        public ConsoleColor InputColor => _theme.InputColor;
        #endregion

        public void ResetColor()
        {
            _ch_color(PrimeColor);
        }

        public DialogStream() { }

        public DialogStream(ColorTheme theme)
        {
            _theme = theme;
        }

    }
}
