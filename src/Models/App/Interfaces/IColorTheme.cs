using System;

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
        ConsoleColor PrimeryColor { get; set; }

        /// <summary>
        /// Default color for extra chracters
        /// </summary>
        ConsoleColor SecondColor { get; set; }

        /// <summary>
        /// Default color for warning messges
        /// </summary>
        ConsoleColor WarningColor { get; set; }

        /// <summary>
        /// Default color for error messages in console
        /// </summary>
        ConsoleColor ErrorColor { get; set; }

        /// <summary>
        /// Deafult color for success messages
        /// </summary>
        ConsoleColor SuccessColor { get; set; }

        /// <summary>
        /// Deafult color for information messages
        /// </summary>
        ConsoleColor InformationColor { get; set; }
    }
}
