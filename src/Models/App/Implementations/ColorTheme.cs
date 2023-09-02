using System;
using System.Drawing;

namespace ConsolePages
{
    /// <summary>
    /// Color theme of printed texts in console page
    /// </summary>
    public class ColorTheme : IColorTheme
    {
        public ConsoleColor PrimeryColor { get; set; }
        public ConsoleColor SecondColor { get; set; }
        public ConsoleColor WarningColor { get; set; }
        public ConsoleColor ErrorColor { get; set; }
        public ConsoleColor SuccessColor { get; set; }

        /// <summary>
        /// Default constructor, provide default color theme
        /// </summary>
        public ColorTheme()
        {
            PrimeryColor = ConsoleColor.Gray;
            SecondColor = ConsoleColor.DarkGray;
            WarningColor = ConsoleColor.Yellow;
            ErrorColor = ConsoleColor.Red;
            SuccessColor = ConsoleColor.Green;
        }


        public ColorTheme(Color primeryColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = Color.FromArgb(255, 241, 233);
            WarningColor = Color.FromArgb(214, 153, 39);
            ErrorColor = Color.FromArgb(238, 130, 159);
            SuccessColor = Color.FromArgb(89, 213, 153);
        }
        public ColorTheme(Color primeryColor, Color secondColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = Color.FromArgb(214, 153, 39);
            ErrorColor = Color.FromArgb(238, 130, 159);
            SuccessColor = Color.FromArgb(89, 213, 153);
        }

        public ColorTheme(Color primeryColor, Color secondColor, Color warningColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = Color.FromArgb(238, 130, 159);
            SuccessColor = Color.FromArgb(89, 213, 153);
        }

        public ColorTheme(Color primeryColor, Color secondColor, Color warningColor, Color errorColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = errorColor;
            SuccessColor = Color.FromArgb(89, 213, 153);
        }

        public ColorTheme(Color primeryColor, Color secondColor, Color warningColor, Color errorColor, Color successColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = errorColor;
            SuccessColor = successColor;
        }

    }
}
