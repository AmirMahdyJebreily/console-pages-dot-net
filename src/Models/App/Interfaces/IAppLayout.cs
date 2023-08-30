namespace ConsolePages
{
    /// <summary>
    /// Base of content layouts
    /// </summary>
    public interface IAppContentLayout
    {
        /// <summary>
        /// Header of contents, print on top of contents
        /// </summary>
        public ConsoleContent HeadOfContects { get; }
    }
}
