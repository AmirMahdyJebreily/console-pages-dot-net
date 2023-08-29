namespace ConsolePages.Models.App.Interfaces
{
    /// <summary>
    /// Base of content layouts
    /// </summary>
    public class IAppContentLayout
    {
        private string _head_of_contents = string.Empty;
        private string _foot_of_contents = string.Empty;

        /// <summary>
        /// Header of contents, print on top of contents
        /// </summary>
        public string HeadOfContects => _head_of_contents;

        /// <summary>
        /// Footer of contents, print on top of contents
        /// </summary>
        public string FootOfContents => _foot_of_contents;
    }
}
