using ConsolePages;
using System;

namespace ConsolePages
{
    /// <summary>
    /// base of all pages
    /// </summary>
    public interface IPage
    {
        /// <summary>
        /// Layout of content in this page. It is usually copied from CApp data
        /// </summary>
        IAppContentLayout ContentLayout { get; }

        /// <summary>
        /// Main text content of this page
        /// </summary>
        Action<DialogStream> DialogStream { get; }

        IPage Show();
    }
}
