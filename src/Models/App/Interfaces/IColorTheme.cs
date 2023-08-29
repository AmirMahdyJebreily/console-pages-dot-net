using System.Drawing;

namespace ConsolePages.Models.App.Interfaces
{
    public interface IColorTheme
    {
        public Color PrimeryColor { get; set; }
        public Color SecondColor { get; set; }
        public Color WarningColor { get; set; }
        public Color ErrorColor { get; set; }
        public Color SuccessColor { get; set; }
    }
}
