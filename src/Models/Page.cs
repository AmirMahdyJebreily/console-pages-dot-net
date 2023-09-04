using ConsolePages;
using System;

namespace ConsolePages
{
    public class Page : IPage
    {
        #region Private Fields
        private IAppContentLayout _layout = _prvt_sttc._dflt_app_cntnt_lyot;
        private Action<PagesArgs>? _dialog_stream;
        #endregion

        #region Public Properties
        public IAppContentLayout ContentLayout => _layout;
        public Action<PagesArgs>? DialogStream => _dialog_stream;
        #endregion

        #region Constructor(s)
        public Page(IAppContentLayout layout)
        {
            _layout = layout;
        }

        public Page(IAppContentLayout layout, Action<PagesArgs> dialogStream)
        {
            _layout = layout;
            DefineDialog(dialogStream);
        }
        #endregion


        public void DefineDialog(Action<PagesArgs> dialogStream)
        {
            _dialog_stream = dialogStream;
        }

        public void Show()
        {
            PagesArgs args = new PagesArgs();
            this.DialogStream.Invoke(args);
        }
    }
}
