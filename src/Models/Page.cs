using System;

namespace ConsolePages
{
    public class Page : IPage
    {
        #region Private Fields
        private IContentObj _layout = _prvt_sttc._dflt_app_cntnt_lyot;
        private Action<DialogStream>? _dialog_stream;
        #endregion

        #region Public Properties
        public IContentObj ContentLayout => _layout;
        public Action<DialogStream>? DialogStream => _dialog_stream;
        #endregion

        #region Constructor(s)
        public Page(IContentObj layout)
        {
            _layout = layout;
        }

        public Page(IContentObj layout, Action<DialogStream> dialogStream)
        {
            _layout = layout;
            DefineDialog(dialogStream);
        }
        #endregion

        public void DefineDialog(Action<DialogStream> dialogStream)
        {
            _dialog_stream = dialogStream;
        }

        public void Show()
        {
            DialogStream.Invoke(new DialogStream());
        }
    }
}
