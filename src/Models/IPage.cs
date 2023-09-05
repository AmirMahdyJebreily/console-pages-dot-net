using System;

namespace ConsolePages
{
    /// <summary>
    /// base of all pages
    /// </summary>
    public interface IPage : IAppContentLayout
    {
        /// <summary>
        /// Layout of content in this page. It is usually copied from CApp data
        /// </summary>
        IAppContentLayout ContentLayout { get; }

        IPage Show();
    }
}
