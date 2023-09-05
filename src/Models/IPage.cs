using System;

namespace ConsolePages
{
    /// <summary>
    /// base of all pages
    /// </summary>
    public interface IPage : IContentObj
    {
        /// <summary>
        /// Layout of content in this page. It is usually copied from CApp data
        /// </summary>
        IContentObj ContentLayout { get; }
    }
}
