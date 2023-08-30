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
        public Color PrimeryColor { get; set; }

        /// <summary>
        /// Default color for extra chracters
        /// </summary>
        public Color SecondColor { get; set; }

        /// <summary>
        /// Default color for warning messges
        /// </summary>
        public Color WarningColor { get; set; }

        /// <summary>
        /// Default color for error messages in console
        /// </summary>
        public Color ErrorColor { get; set; }

        /// <summary>
        /// Deafult color for success messages
        /// </summary>
        public Color SuccessColor { get; set; }

    }
}
