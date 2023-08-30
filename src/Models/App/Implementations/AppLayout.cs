using System.Drawing;

namespace ConsolePages
{
    /// <summary>
    /// default layout of app 
    /// </summary>
    public class AppLayout : IAppContentLayout
    {
        private ConsoleContent _head_of_content;
        public ConsoleContent HeadOfContects => _head_of_content;

        public AppLayout(params (string, Color?)[] texts)
        {
            _head_of_content.writeContent(texts);
        }

    }
}
