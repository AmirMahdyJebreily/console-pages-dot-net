using System;

namespace ConsolePages
{
    public class PagesArgs
    {
        private Action<object> _print = _prvt_sttc._prntln_mtd;
        private Action<object> _print_nl = _prvt_sttc._prnt_mtd;
        private Action _clear = _prvt_sttc._cln_mtd;
        private ColorTheme _theme = _prvt_sttc._dflt_color_theme;



        #region Print Method
        public void Print(string text)
        {
            _print(text);
        }
        #endregion
        public Action<string> PrintNL => _print_nl;
        public Action Clear => _clear;
        public ColorTheme Theme => _theme;

        public PagesArgs()
        {
            
        }

        public PagesArgs(ColorTheme theme)
        {
            _theme = theme;
        }

    }
}
