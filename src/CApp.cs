using System.Reflection;

namespace ConsolePages
{
    /// <summary>
    /// Your Console Application 
    /// </summary>
    public class CApp
    {
        #region Fields
        private IPage _main_Page;
        private IPage _page;
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
        public IPage Page => _page;

        /// <summary>
        /// contents layout of the app
        /// </summary>
        public IAppContentLayout Layout => _layout;

        //...
        #endregion

        #region Constructors
        public CApp(IPage main_Page)
        {
            _title = Assembly.GetCallingAssembly().GetName().Name;
            _layout = _prvt_sttc._dflt_app_cntnt_lyot;
            _page = new Page(_layout);
            _main_Page = main_Page;
        }

        #endregion

        public void ShowPage(IPage page)
        {
            _prvt_sttc._cln_mtd();
            _page = page.Show();
        }

        public void ShowMainPage() => ShowPage(_main_Page);
    }
}