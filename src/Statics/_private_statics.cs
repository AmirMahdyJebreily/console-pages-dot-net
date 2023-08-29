using System;
using ConsolePages.Models.App.Interfaces;

namespace ConsolePages
{
    internal static class _prvt_sttc
    {
        /// <summary>
        /// print method delegate
        /// </summary>
        internal static Action<object> _prnt_mtd;

        /// <summary>
        /// print + new line method delegate
        /// </summary>
        internal static Action<object> _prntln_mtd;

        /// <summary>
        /// clean method delegate
        /// </summary>
        internal static Action<object> _cln_mtd;

        /// <summary>
        /// color theme object
        /// </summary>
        internal static IColorTheme _theme = _dflt_color_theme;


        // TODO : Add layout field as default layout


        // TODO : for whene Impliment IColorTheme Interface :
        internal static IColorTheme _dflt_color_theme;
    }
}
