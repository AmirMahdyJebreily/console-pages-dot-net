using System;

namespace ConsolePages
{
    /// <summary>
    /// default layout of app 
    /// </summary>
    public class AppLayout : IContentObj
    {
        private Action<DialogStream> _head_of_content;

        /// <summary>
        /// Head dialog stream
        /// </summary>
        public Action<DialogStream> DialogStream => _head_of_content;

        public AppLayout()
        {
            this.Set((a) => { });
        }

        public AppLayout(IContentObj content)
        {
            this.Set(content.DialogStream);
        }

        public void Set(Action<DialogStream> content)
        {
            _head_of_content = content;
        }

        public void SetFromPage(IPage page)
        {
            _head_of_content = page.DialogStream;
        }

        public void Show()
        {
            DialogStream.Invoke(new DialogStream());
        }

    }
}
