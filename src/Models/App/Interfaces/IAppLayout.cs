using System;

namespace ConsolePages
{
    /// <summary>
    /// Base of content layouts
    /// </summary>
    public interface IAppContentLayout
    {
        /// <summary>
        /// Dialog stream is a stream of consecutive print and input methodes to standarn I/O
        /// </summary>
        public Action<DialogStream> DialogStream { get; }
    }
}
