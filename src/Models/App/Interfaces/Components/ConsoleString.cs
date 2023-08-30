using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ConsolePages
{
    public class ConsoleString
    {
        private List<TextPart> _content;

        public List<TextPart> Content => _content;

        public ConsoleString() { }
        public ConsoleString(string jsonFormat) { }


        public void writeContent(TextPart line)
        {
            _content.Add(line);
        }

        public void writeContent(List<TextPart> lines)
        {
            lines.ForEach(l =>
            {
                writeContent(new List<TextPart> { l });
            });
        }

        public void writeContent(params (string, Color?)[] lines)
        {
            foreach (var line in lines)
            {
                string text = line.Item1;
                var color = (line.Item2 == null) ? _prvt_sttc._theme.PrimeryColor : line.Item2.Value;
                writeContent(new TextPart(text, color));
            }
        }

        public void writeContent(string text)
            => writeContent(new TextPart(text, _prvt_sttc._theme.PrimeryColor));


        public void writeContent(string text, Color color)
            => writeContent(new TextPart(text, color));


        public void writeContent(string seprator, params string[] texts)
        {
            foreach (var text in texts)
            {
                writeContent(new TextPart(text + seprator, _prvt_sttc._theme.PrimeryColor));
            }
        }

        public void removeContent(string lablName)
        {
            _content.Remove(_content.FirstOrDefault(a => a.Lablename == lablName));
        }

    }
}
