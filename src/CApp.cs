using System.Collections.Generic;
using ConsolePages.Models;

namespace ConsolePages
{
    public class CApp
    {
        #region Fields
        private List<IPage> _pages;
        private string _title;
        //...
        #endregion

        #region Properties
        public string AppTitle => _title;
        public List<IPage> Pages => _pages;
        //...
        #endregion
    }
}