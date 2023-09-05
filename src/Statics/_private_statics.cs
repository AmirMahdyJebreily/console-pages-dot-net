using System;
using System.Drawing;

namespace ConsolePages
{
    internal static class _prvt_sttc
    {
        /// <summary>
        /// print method delegate
        /// </summary>
        internal static Action<object> _prnt_mtd = (_t_) => Console.Write(_t_);

        /// <summary>
        /// print + new line method delegate
        /// </summary>
        internal static Action<object> _prntln_mtd = (_t_) => Console.WriteLine(_t_);

        /// <summary>
        /// change color methode
        /// </summary>
        internal static Action<ConsoleColor> _chng_color_mtd = (_c_) => Console.ForegroundColor = _c_;

        /// <summary>
        /// print + new line method delegate
        /// </summary>
        internal static Func<string> _input_mtd = (() => Console.ReadLine());

        /// <summary>
        /// clean method delegate
        /// </summary>
        internal static Action _cln_mtd = () => Console.Clear();

        /// <summary>
        /// color theme object
        /// </summary>
        internal static IColorTheme _theme = _dflt_color_theme;

        /// <summary>
        /// default layout of pages
        /// </summary>
        internal static IContentObj _dflt_app_cntnt_lyot = new AppLayout(
                ("Wellcome to my program", Color.Fuchsia)
            );

        /// <summary>
        /// default color theme
        /// </summary>
        internal static ColorTheme _dflt_color_theme = new ColorTheme();
    }
}
