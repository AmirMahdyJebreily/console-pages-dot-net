using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ConsolePages
{
    /// <summary>
    /// Format for all contents
    /// </summary>
    public class ConsoleContent
    {
        private List<TextPart> _content;

        /// <summary>
        /// Text data of this content
        /// </summary>
        public List<TextPart> Content => _content;

        public ConsoleContent() { }


        /// <summary>
        /// write a text in content
        /// </summary>
        /// <param name="line"><see cref="TextPart"/> format input for write in content</param>
        public void writeContent(TextPart line)
        {
            _content.Add(line);
        }

        /// <summary>
        /// Write multiple texts in the content
        /// </summary>
        /// <param name="lines">list of <see cref="TextPart"/> format input for write in content</param>
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
