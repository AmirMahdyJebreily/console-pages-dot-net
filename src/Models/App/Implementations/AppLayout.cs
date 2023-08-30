using System.Drawing;

namespace ConsolePages
{
    public class AppLayout : IAppContentLayout
    {
        private ConsoleString _head_of_content;
        public ConsoleString HeadOfContects => _head_of_content;

        public AppLayout(params (string, Color?)[] texts)
        {
            _head_of_content.writeContent(texts);
        }

    }
}
