using System;

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
        public ConsoleColor InformationColor { get; set; }

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
            InformationColor = ConsoleColor.DarkCyan;
        }


        public ColorTheme(ConsoleColor primeryColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = ConsoleColor.DarkGray;
            WarningColor = ConsoleColor.Yellow;
            ErrorColor = ConsoleColor.Red;
            SuccessColor = ConsoleColor.Green;
            InformationColor = ConsoleColor.DarkBlue;
        }
        public ColorTheme(ConsoleColor primeryColor, ConsoleColor secondColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = ConsoleColor.Yellow;
            ErrorColor = ConsoleColor.Red;
            SuccessColor = ConsoleColor.Green;
            InformationColor = ConsoleColor.DarkBlue;
        }

        public ColorTheme(ConsoleColor primeryColor, ConsoleColor secondColor, ConsoleColor warningColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = ConsoleColor.Red;
            SuccessColor = ConsoleColor.Green;
            InformationColor = ConsoleColor.DarkBlue;
        }

        public ColorTheme(ConsoleColor primeryColor, ConsoleColor secondColor, ConsoleColor warningColor, ConsoleColor errorColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = errorColor;
            SuccessColor = ConsoleColor.Green;
            InformationColor = ConsoleColor.DarkBlue;
        }

        public ColorTheme(ConsoleColor primeryColor, ConsoleColor secondColor, ConsoleColor warningColor, ConsoleColor errorColor, ConsoleColor successColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = errorColor;
            SuccessColor = successColor;
            InformationColor = ConsoleColor.DarkBlue;
        }

        public ColorTheme(ConsoleColor primeryColor, ConsoleColor secondColor, ConsoleColor warningColor, ConsoleColor errorColor, ConsoleColor successColor, ConsoleColor infoColor)
        {
            PrimeryColor = primeryColor;
            SecondColor = secondColor;
            WarningColor = warningColor;
            ErrorColor = errorColor;
            SuccessColor = successColor;
            InformationColor = infoColor;
        }

    }
}
