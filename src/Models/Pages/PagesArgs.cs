using System;

namespace ConsolePages.Models.Pages
{
    public class PagesArgs
    {
        private Action<PagesArgs> _print = _prvt_sttc._prntln_mtd;
        private Action<PagesArgs> _print_nl = _prvt_sttc._prnt_mtd;
        private Action<PagesArgs> _clear = _prvt_sttc._cln_mtd;
        private ColorTheme _theme = _prvt_sttc._dflt_color_theme;



        public Action<PagesArgs> Print => _print;
        public Action<PagesArgs> PrintNL => _print_nl;
        public Action<PagesArgs> Clear => _clear;
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
