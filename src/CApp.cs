using System.Collections.Generic;

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
        private IAppContentLayout _layout;
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

        /// <summary>
        /// contents layout of the app
        /// </summary>
        public IAppContentLayout Layout => _layout;

        //...
        #endregion
    }
}