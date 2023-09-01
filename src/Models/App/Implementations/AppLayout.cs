using System.Drawing;
using System.Linq;

namespace ConsolePages
{
    /// <summary>
    /// default layout of app 
    /// </summary>
    public class AppLayout : IAppContentLayout
    {
        private string _head_of_content;
        public string HeadOfContents => _head_of_content;

        public AppLayout(params (string, Color?)[] texts)
        {
            
        }

    }
}
