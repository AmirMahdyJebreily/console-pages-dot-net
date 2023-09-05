using System;

namespace ConsolePages
{
    /// <summary>
    /// Base of content layouts
    /// </summary>
    public interface IContentObj
    {
        /// <summary>
        /// Dialog stream is a stream of consecutive print and input methodes to standarn I/O
        /// </summary>
        public Action<DialogStream> DialogStream { get; }

        /// <summary>
        /// A method to execute the <see cref="DialogStream"/>
        /// </summary>
        void Show();
    }
}
