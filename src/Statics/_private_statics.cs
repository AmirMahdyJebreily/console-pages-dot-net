using System;
using ConsolePages.Models.App.Interfaces;

namespace ConsolePages
{
    internal static class _prvt_sttc
    {
        internal static Action<object> _prnt_mtd;
        internal static Action<object> _prntln_mtd;
        internal static Action<object> _cln_mtd;
        internal static IColorTheme _theme;


        // TODO : for whene Impliment IColorTheme Interface :
        // internal const IColorTheme _dflt_color_theme;
    }
}
