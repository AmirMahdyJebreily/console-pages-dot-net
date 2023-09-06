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
        internal static Func<string> _input_mtd = () => Console.ReadLine();

        /// <summary>
        /// print + new line method delegate
        /// </summary>
        internal static Func<ConsoleKeyInfo> _command_mtd = () => Console.ReadKey();

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
        internal static AppLayout _dflt_app_cntnt_lyot = new AppLayout(
                (args) => { }
            );

        /// <summary>
        /// default color theme
        /// </summary>
        internal static ColorTheme _dflt_color_theme = new ColorTheme();


        /// <summary>
        /// Convert object to true Console App Content Format
        /// </summary>
        /// <param name="obj">Objects array thats most include <see cref="string"/>s and Couple Tuples <see cref="(string, ConsoleColor)"/></param>
        /// <returns>a (string, ConsoleColor?) </returns>
        internal static (string, ConsoleColor?) _obj2TCAPPF(object obj)
        {
            string strValue = string.Empty;
            ConsoleColor? color = null;

            var item = obj;

            if (item.GetType() == typeof((string, ConsoleColor)))
            {
                strValue = (((string, ConsoleColor))item).Item1;
                color = (((string, ConsoleColor))item).Item2;
            }
            else
            {
                strValue = obj.ToString();
            }

            return (strValue, color);

        }

        /// <summary>
        /// Convert object array to true Console App Content Format
        /// </summary>
        /// <param name="objects">Objects array thats most include <see cref="string"/>s and Couple Tuples <see cref="(string, ConsoleColor)"/></param>
        /// <returns>an array of (string, ConsoleColor?) </returns>
        internal static (string, ConsoleColor?)[] _objArr2TCAPPF(params object[] objects)
        {
            (string, ConsoleColor?)[] res = new (string, ConsoleColor?)[objects.Length];
            for (int i = 0; i < objects.Length; i++)
            {
                res[i] = _obj2TCAPPF(objects[i]);
            }
            return res;
        }
    }
}
