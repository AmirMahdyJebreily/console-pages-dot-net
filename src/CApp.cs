using System.Collections.Generic;
using ConsolePages.Models;

namespace ConsolePages
{
    /// <summary>
    /// Your Console Application 
    /// </summary>
    public class CApp
    {
        #region Fields
        private List<IPage> _pages;
        private string _title;
        //...
        #endregion

        #region Properties
        /// <summary>
        /// Title of your console app
        /// </summary>
        public string AppTitle => _title;

        /// <summary>
        /// Your console apps' Pages
        /// </summary>
        public List<IPage> Pages => _pages;
        //...
        #endregion
    }
}