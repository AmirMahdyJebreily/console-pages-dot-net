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
        private AppLayout _layout;
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
        public AppLayout Layout => _layout;

        //...
        #endregion

        #region Constructors
        public CApp()
        {
            _title = Assembly.GetCallingAssembly().GetName().Name;
            _layout = _prvt_sttc._dflt_app_cntnt_lyot;
            _page = new Page(_layout);
            _main_Page = new Page(_layout);
        }

        #endregion

        private void _showLayout()
        {
            _prvt_sttc._cln_mtd();
            Layout.Show();
        }

        public void ShowPage(IPage page)
        {
            _showLayout();
            _page = page;
            _page.Show();
        }

        public void ShowMainPage() => ShowPage(_main_Page);
    }
}