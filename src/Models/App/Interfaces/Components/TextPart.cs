using System.Drawing;

namespace ConsolePages
{
    public class TextPart
    {
        public string Text { get; set; }
        public Color PartColor { get; set; }
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
