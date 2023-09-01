using System;
using System.Drawing;

namespace ConsolePages
{
    internal static class _prvt_sttc
    {
        /// <summary>
        /// print method delegate
        /// </summary>
        internal static Action _prnt_mtd;

        /// <summary>
        /// print + new line method delegate
        /// </summary>
        internal static Action _prntln_mtd;

        /// <summary>
        /// change color methode
        /// </summary>
        internal static Action _chng_color_mtd;

        /// <summary>
        /// clean method delegate
        /// </summary>
        internal static Action _cln_mtd;

        /// <summary>
        /// color theme object
        /// </summary>
        internal static IColorTheme _theme = _dflt_color_theme;

        /// <summary>
        /// default layout of pages
        /// </summary>
        internal static IAppContentLayout _dflt_app_cntnt_lyot = new AppLayout(
                ("Wellcome to my program", Color.Fuchsia)
            );

        /// <summary>
        /// default color theme
        /// </summary>
        internal static IColorTheme _dflt_color_theme = new ColorTheme();
    }
}
