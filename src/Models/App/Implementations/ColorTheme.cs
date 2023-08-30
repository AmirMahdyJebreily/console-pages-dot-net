using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsolePages
{
    public class ColorTheme : IColorTheme
    {
        public Color PrimeryColor { get; set; }
        public Color SecondColor { get; set; }
        public Color WarningColor { get; set; }
        public Color ErrorColor { get; set; }
        public Color SuccessColor { get; set; }


        public ColorTheme()
        {
            PrimeryColor = Color.White;
            SecondColor = Color.FromArgb(255, 241, 233);
            WarningColor = Color.FromArgb(214, 153, 39);
            ErrorColor = Color.FromArgb(238, 130, 159);
            SuccessColor = Color.FromArgb(89, 213, 153);
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
