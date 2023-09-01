using System.Collections.Generic;
using System.Reflection;

namespace ConsolePages
{
    /// <summary>
    /// Your Console Application 
    /// </summary>
    public class CApp
    {
        #region Fields
        private IPage _page_model;
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
        public IPage InLinePage => _page_model;

        /// <summary>
        /// contents layout of the app
        /// </summary>
        public IAppContentLayout Layout => _layout;

        //...
        #endregion

        #region Constructors
        public CApp()
        {
            _layout = _prvt_sttc._dflt_app_cntnt_lyot;
            _page_model = new Page(_layout);
            _title = Assembly.GetCallingAssembly().GetName().Name;
        }
        #endregion
    }
}