using System;
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
        private ColorTheme _theme;
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

        /// <summary>
        /// color theme of the app
        /// </summary>
        public ColorTheme Theme => _theme;

        //...
        #endregion

        #region Constructors
        public CApp()
        {
            _title = Assembly.GetCallingAssembly().GetName().Name;
            _layout = _prvt_sttc._dflt_app_cntnt_lyot;
            _page = new Page(_layout);
            _main_Page = new Page(_layout);
            _theme = _prvt_sttc._dflt_color_theme;
        }

        #endregion

        #region Customizing
        public void AddColorTheme(ColorTheme theme)
        {
            _theme = theme;
        }
        #endregion

        public void AddLayout(IContentObj content)
        {
            _layout = new AppLayout(content);
        }

        public void SetMainPage(IPage page)
        {
            _main_Page = page;
        }

        private void _showLayout(IPage page)
        {
            _prvt_sttc._cln_mtd();
            page.ContentLayout.Show();
        }

        public void ShowPage(IPage page)
        {
            _showLayout(page);
            _page = page;
            _page.Show();
        }

        public void ShowPage(Action<DialogStream> dialogStream)
        {
            _page = new Page(_layout, dialogStream);
            _showLayout(_page);
            _page.Show();
        }

        public void ShowPage(Action dialogStream)
        {
            _page = new Page(_layout, (a) => dialogStream());
            _showLayout(_page);
            _page.Show();
        }

        public void ShowMainPage(bool loop = false)
        {
            if (loop)
            {
                while (true)
                {
                    ShowPage(_main_Page);
                }
            }
            else
            {
                ShowPage(_main_Page);
            }
        }
    }
}