using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using MyClassCollection;
using Library_System;

namespace RibbonSupport
{
    class RibbonSupportClass
    {
        frmMain mf;
        private MySQLDBUtilities db = new MySQLDBUtilities();
        public RibbonSupportClass(RibbonForm rf)
        {
            mf = (frmMain)rf;
        }
        public void SaveNow(SaveSender ss)
        {
            if (ss == SaveSender.AddBook)
            {
                SaveBook();
            }
        }
        private void SaveBook()
        {
            addBookInfo abi = (addBookInfo)mf.scMain.Panel1.Controls[0];
            abi.SaveDB();
        }
    }
    public enum SaveSender
    {
        AddBook
    }
}
