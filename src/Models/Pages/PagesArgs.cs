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
        public void PrintNl(object obj) => _print(obj);
        public void PrintNl(string text) => _print(text);
        public void PrintNl(string text, ConsoleColor color)
        {
            _ch_color(color);
            _print(text);
            _ch_color(_theme.PrimeryColor);

        }
        public void PrintNl(string sep = " ", params string[] texts) => PrintNl(string.Join(sep, texts));
        public void PrintNl(params string[] texts) => PrintNl(string.Join(" ", texts));
        public void PrintNl(string sep = " ", params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl(sep); // add seprator to texts
                }

            }
        }
        public void PrintNl(params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl(" "); // add seprator to texts
                }

            }
        }
        #endregion

        #region Print Method
        public void Print(object obj) => PrintNl(obj.ToString(), "\n");
        public void Print(string text) => Print(text);
        public void Print(string text, ConsoleColor color)
        {
            _ch_color(color);
            PrintNl(text, "\n");
            _ch_color(_theme.PrimeryColor);

        }
        public void Print(string[] texts, string sep = "\n") => PrintNl(string.Join(sep, texts));
        public void Print(params string[] texts) => PrintNl(string.Join("\n", texts));

        public void Print((string, ConsoleColor)[] texts, string sep = "\n")
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl(sep); // add seprator to texts
                }

            }
        }

        public void Print(params (string, ConsoleColor)[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                _ch_color(texts[i].Item2);
                PrintNl(texts[i].Item1);
                _ch_color(_theme.PrimeryColor);

                if (i + 1 != texts.Length)
                {
                    PrintNl("\n"); // add seprator to texts
                }

            }
        }
        #endregion

        public Action Clear => _clear;

        #region Colors of Theme
        public ColorTheme Theme => _theme;

        public ConsoleColor PrimeryColor => _theme.PrimeryColor;
        public ConsoleColor SecondColor => _theme.SecondColor;
        public ConsoleColor WarningColor => _theme.WarningColor;
        public ConsoleColor ErrorColor => _theme.ErrorColor;
        public ConsoleColor SuccessColor => _theme.SuccessColor;
        public ConsoleColor InformationColor => _theme.InformationColor;
        #endregion

        public PagesArgs() { }

        public PagesArgs(ColorTheme theme)
        {
            _theme = theme;
        }

    }
}
