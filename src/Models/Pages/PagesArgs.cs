using System;

namespace ConsolePages
{
    public class PagesArgs
    {
        private Action<object> _print = _prvt_sttc._prnt_mtd;
        private Action<ConsoleColor> _ch_color = _prvt_sttc._chng_color_mtd;
        private Action _clear = _prvt_sttc._cln_mtd;
        private ColorTheme _theme = _prvt_sttc._dflt_color_theme;



        #region Print Method
        public void Print(object obj) => _print(obj);
        public void Print(string text) => _print(text);
        public void Print(string text, ConsoleColor color)
        {
            _ch_color(color);
            _print(text);
            _ch_color(_theme.PrimeryColor);

        }
        public void Print(string sep = " ", params string[] texts) => Print(string.Join(sep, texts));
        public void Print(params string[] texts) => Print(string.Join(" ", texts));
        public void Print(string sep = " ", params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                Print(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    Print(sep); // add seprator to texts
                }

            }
        }
        public void Print(params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                Print(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    Print(" "); // add seprator to texts
                }

            }
        }
        #endregion

        #region PrintLn Method
        public void PrintLn(object obj) => Print(obj.ToString(), "\n");
        public void PrintLn(string text) => PrintLn(text);
        public void PrintLn(string text, ConsoleColor color)
        {
            _ch_color(color);
            Print(text, "\n");
            _ch_color(_theme.PrimeryColor);

        }
        public void PrintLn(string sep = "\n", params string[] texts) => Print(string.Join(sep, texts));
        public void PrintLn(params string[] texts) => Print(string.Join("\n", texts));

        public void PrintLn(string sep = "\n", params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                Print(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    Print(sep); // add seprator to texts
                }

            }
        }

        public void PrintLn(params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                Print(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    Print("\n"); // add seprator to texts
                }

            }
        }
        #endregion

        public Action Clear => _clear;
        public ColorTheme Theme => _theme;

        public PagesArgs() { }

        public PagesArgs(ColorTheme theme)
        {
            _theme = theme;
        }

    }
}
