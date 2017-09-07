using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassCollection;
using RibbonSupport;
using DevExpress.XtraSplashScreen;

namespace Library_System
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private RibbonSupportClass rsc;
        private SaveSender ss;
        public static string userLoggedIn = null;
        public static bool triggerDesigner = false;

        public frmMain()
        {
            InitializeComponent();
            rsc = new RibbonSupportClass(this);
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ss = SaveSender.AddBook;
            rpgBookModifier.Enabled = false;
            ClearPanel();
            addBookInfo info = new addBookInfo();
            info.Dock = DockStyle.Fill;
            info.btnMultiAuthor.Checked = false;
            scMain.Panel1.Controls.Add(info);
            scMain.Panel1.Enabled = true;
            addBookAuthor auth = new addBookAuthor();
            auth.Dock = DockStyle.Fill;
            auth.Size = scMain.Size;
            scMain.Panel2.Controls.Add(auth);
            scMain.Panel2.Enabled = false;
        }

        private void btnSaveBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rsc.SaveNow(ss);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (userLoggedIn == null)
            {
                frmLogin log = new frmLogin();
                log.ShowDialog();
            }
        }

        private void tmDesigner_Tick(object sender, EventArgs e)
        {
            if (triggerDesigner)
            {
                if (userLoggedIn.Equals("Guest"))
                {
                    ribBooks.Visible = false;
                    ribBorrowing.Visible = false;
                    ribManageAccounts.Visible = false;
                    ribBorrower.Visible = true;
                }
                else if (userLoggedIn.Equals("-1"))
                {
                    ribBooks.Visible = true;
                    ribBorrowing.Visible = true;
                    ribManageAccounts.Visible = true;
                    ribBorrower.Visible = true;
                }
                else
                {
                    ribBooks.Visible = true;
                    ribBorrowing.Visible = true;
                    ribManageAccounts.Visible = true;
                    ribBorrower.Visible = false;
                }
                triggerDesigner = false;
            }
        }
        private void ClearPanel()
        {
            scMain.Panel1.Controls.Clear();
            scMain.Panel2.Controls.Clear();
        }
    }
}
