using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsolePages.Models.App.Implementations
{
    public class ColorTheme : IColorTheme
    {
        public Color PrimeryColor { get; set; }
        public Color SecondColor { get; set; }
        public Color WarningColor { get; set; }
        public Color ErrorColor { get; set; }
        public Color SuccessColor { get; set; }
    }
}
