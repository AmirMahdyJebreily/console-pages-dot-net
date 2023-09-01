namespace ConsolePages
{
    public class Page : IPage
    {
        #region Private Fields
        private IAppContentLayout _layout = _prvt_sttc._dflt_app_cntnt_lyot;
        #endregion

        #region Public Properties
        public IAppContentLayout ContentLayout => _layout;
        public string MainContent { get; set; }
        #endregion

        public Page(IAppContentLayout layout)
        {
            _layout = layout;
        }

        

    }
}
