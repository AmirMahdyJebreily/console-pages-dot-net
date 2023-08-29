namespace ConsolePages.Models.App.Interfaces
{
    public class IAppContentLayout
    {
        private string _head_of_contents = string.Empty;
        private string _foot_of_contents = string.Empty;
        public string HeadOfContects => _head_of_contents;
        public string FootOfContents => _foot_of_contents;
    }
}
