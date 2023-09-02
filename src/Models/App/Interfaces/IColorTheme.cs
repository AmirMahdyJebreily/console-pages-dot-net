using System;
using System.Drawing;

namespace ConsolePages
{
    /// <summary>
    /// Base of color themes in application
    /// </summary>
    public interface IColorTheme
    {
        /// <summary>
        /// Default color for texts
        /// </summary>
        public ConsoleColor PrimeryColor { get; set; }

        /// <summary>
        /// Default color for extra chracters
        /// </summary>
        public ConsoleColor SecondColor { get; set; }

        /// <summary>
        /// Default color for warning messges
        /// </summary>
        public ConsoleColor WarningColor { get; set; }

        /// <summary>
        /// Default color for error messages in console
        /// </summary>
        public ConsoleColor ErrorColor { get; set; }

        /// <summary>
        /// Deafult color for success messages
        /// </summary>
        public ConsoleColor SuccessColor { get; set; }

    }
}
