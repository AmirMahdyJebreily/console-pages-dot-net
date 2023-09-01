using System;

namespace ConsolePages.Models.Pages
{
    public class PagesArgs
    {
        public Action Print => _prvt_sttc._prntln_mtd;
        public Action PrintNL => _prvt_sttc._prnt_mtd;
        public Action Clear => _prvt_sttc._cln_mtd;

    }
}
