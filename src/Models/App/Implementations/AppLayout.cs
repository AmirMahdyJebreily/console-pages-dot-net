using System;
using System.Drawing;

namespace ConsolePages
{
    /// <summary>
    /// default layout of app 
    /// </summary>
    public class AppLayout : IAppContentLayout
    {
        private Action<DialogStream> _head_of_content;

        /// <summary>
        /// Head dialog stream
        /// </summary>
        public Action<DialogStream> DialogStream => _head_of_content;

        public AppLayout(Action<DialogStream> content)
        {
            _head_of_content = content;
        }

        public void Set(Action<DialogStream> content)
        {
            _head_of_content = content; 
        }

        public void SetFromPage(IPage page)
        {
            _head_of_content = page.DialogStream;
        }
    }
}
