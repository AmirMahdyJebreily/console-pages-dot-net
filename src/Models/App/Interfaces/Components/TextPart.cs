using System.Drawing;

namespace ConsolePages
{
    /// <summary>
    /// little part of printed content in console page
    /// </summary>
    public class TextPart
    {
        /// <summary>
        /// Text of this part of content
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Color of this part
        /// </summary>
        public Color PartColor { get; set; }

        /// <summary>
        /// lable name of this part for remove of edit
        /// </summary>
        public string? Lablename { get; set; }

        public TextPart()
        {
            Text = "";
            PartColor = _prvt_sttc._theme.PrimeryColor;
            Lablename = null;
        }

        public TextPart(string text)
        {
            Text = text;
            PartColor = _prvt_sttc._theme.PrimeryColor;
            Lablename = null;
        }

        public TextPart(string text, Color color)
        {
            Text = text;
            PartColor = color;
            Lablename = null;
        }

        public TextPart(string text, Color color, string lableName)
        {
            Text = text;
            PartColor = color;
            Lablename = lableName;
        }


        public static TextPart New(string text)
        {
            TextPart res = new TextPart(text);
            return res;
        }

        public static TextPart New(string text, Color color)
        {
            TextPart res = new TextPart(text, color);
            return res;
        }

        public static TextPart New(string text, Color color, string lableName)
        {
            TextPart res = new TextPart(text, color, lableName);
            return res;
        }

    }
}
