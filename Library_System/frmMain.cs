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
using Library_System.Manage_Users;
using Library_System.Manage_Books;
using DevExpress.Utils;
using DevExpress.XtraBars;
using Library_System.Borrowers_Menu;
using Library_System.Borrowing_Menu;

namespace Library_System
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private RibbonSupportClass rsc;
        public static SaveSender ss = SaveSender.None;
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
            ClearPanel();
            addBookInfo info = new addBookInfo();
            info.Dock = DockStyle.Fill;
            info.btnMultiAuthor.Checked = false;
            scMain.SplitterPosition = info.Size.Width;
            scMain.Panel1.Controls.Add(info);
            scMain.Panel1.Enabled = true;
            addBookAuthor auth = new addBookAuthor();
            auth.Dock = DockStyle.Fill;
            auth.Size = scMain.Size;
            scMain.Panel2.Controls.Add(auth);
            scMain.Panel2.Enabled = false;
            ClearCheckDoCheck(btnAddBooks);
            rpgPrintingTool.Visible = false;
        }

        private void btnSaveBooks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ss != SaveSender.None)
                rsc.SaveNow(ss);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (userLoggedIn == null)
            {
                ribTabs.Visible = false;
                frmLogin log = new frmLogin();
                log.ShowDialog();
            }
        }

        private void tmDesigner_Tick(object sender, EventArgs e)
        {
            if (triggerDesigner)
            {
                ribTabs.Visible = true;
                if (userLoggedIn.Equals("Guest"))
                {
                    ribBooks.Visible = false;
                    ribBorrowing.Visible = false;
                    ribManageAccounts.Visible = false;
                    ribBorrower.Visible = true;
                    ribSettings.Visible = false;
                }
                else if (userLoggedIn.Equals("Admin"))
                {
                    ribBooks.Visible = false;
                    ribBorrowing.Visible = false;
                    ribManageAccounts.Visible = true;
                    ribBorrower.Visible = false;
                    ribSettings.Visible = false;
                    if (HasPendingRegister())
                    {
                        ribTabs.SelectedPage = ribManageAccounts;
                        ApproveForm();
                        ClearCheckDoCheck(btnApproveRegistration);
                    }
                }
                else
                {
                    ribBooks.Visible = true;
                    ribBorrowing.Visible = true;
                    ribManageAccounts.Visible = false;
                    ribBorrower.Visible = false;
                    ribSettings.Visible = true;
                    if (HasPendingRegister())
                    {
                        ribTabs.SelectedPage = ribBorrowing;
                        ApproveForm();
                    }
                }
                triggerDesigner = false;
            }
        }
        private bool HasPendingRegister()
        {
            DataTable data = db.SelectTable("SELECT * FROM tblborrower WHERE status = 'Request';");
            if (data != null)
            {
                if (data.Rows.Count > 0)
                    return true;
            }
            return false;
        }
        private void ClearPanel()
        {
            scMain.Panel1.Controls.Clear();
            scMain.Panel2.Controls.Clear();
        }

        private void btnSaveAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ss != SaveSender.None)
            {
                rsc.SaveNow(ss);
                //((viewUsers)scMain.Panel2.Controls[0]).LoadList();
            }
        }

        private void btnAddAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.AddUser;
            addUser au = new addUser();
            au.Dock = DockStyle.Fill;
            scMain.SplitterPosition = au.Size.Width;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(au);

            viewUsers vu = new viewUsers(ss);
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnAddAccount);
        }

        private void btnUpdateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.UpdateUser;
            viewUsers vu = new viewUsers(ss);
            scMain.SplitterPosition = 0;
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnUpdateAccount);
        }

        private void btnResetPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ResetPassword;
            viewUsers vu = new viewUsers(ss);
            scMain.SplitterPosition = 0;
            vu.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(vu);
            ClearCheckDoCheck(btnResetPassword);
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearCheckDoCheck(null);
            userLoggedIn = null;
            ribTabs.Visible = false;
            ClearPanel();
            frmLogin log = new frmLogin();
            log.ShowDialog();
        }

        private void ribTabs_SelectedPageChanged(object sender, EventArgs e)
        {
            ss = SaveSender.None;
            ClearPanel();
            ClearCheckDoCheck(null);
            HideAll();
        }
        private void HideAll()
        {
            rpgPrintingTool.Visible = false;
            rpgBorrowingTools.Visible = false;
            rpgReceiveTools.Visible = false;
            rpgBorrowingSave.Visible = false;
            rpgBorrowerTools.Visible = false;
            rpgPenaltyTools.Visible = false;
        }
        private void btnEditSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditSubject;
            subjectManage sm = new subjectManage(ss);
            scMain.SplitterPosition = this.Size.Width;
            sm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(sm);
            ClearCheckDoCheck(btnEditSubject);
            rpgPrintingTool.Visible = false;
        }

        private void btnDeleteSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.DeleteSubject;
            subjectManage sm = new subjectManage(ss);
            scMain.SplitterPosition = this.Size.Width;
            sm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(sm);
            ClearCheckDoCheck(btnDeleteSubjects);
            rpgPrintingTool.Visible = false;
        }
        private void btnEditPublisher_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditPublisher;
            publisherManage pm = new publisherManage(ss);
            scMain.SplitterPosition = this.Size.Width;
            pm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(pm);
            ClearCheckDoCheck(btnEditPublisher);
            rpgPrintingTool.Visible = false;
        }
        private void btnDeletePublisher_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.DeletePublisher;
            publisherManage pm = new publisherManage(ss);
            scMain.SplitterPosition = this.Size.Width;
            pm.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(pm);
            ClearCheckDoCheck(btnDeletePublisher);
            rpgPrintingTool.Visible = false;
        }
        private void btnEditAuthor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditAuthor;
            authorManage am = new authorManage(ss);
            scMain.SplitterPosition = 0;
            am.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(am);
            ClearCheckDoCheck(btnEditAuthor);
            rpgPrintingTool.Visible = false;
        }

        private void btnDeleteAuthor_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.DeleteAuthor;
            authorManage am = new authorManage(ss);
            scMain.SplitterPosition = 0;
            am.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(am);
            ClearCheckDoCheck(btnDeleteAuthor);
            rpgPrintingTool.Visible = false;
        }
        private void btnEditBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditBook;
            Books b = new Books(ss);
            scMain.SplitterPosition = b.Size.Width;
            b.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(b);
            Authors a = new Authors(new DataTable());
            scMain.Panel2.Enabled = true;
            a.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(a);
            ClearCheckDoCheck(btnEditBook);
            rpgPrintingTool.Visible = false;
        }

        private void btnDeleteBooks_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.DeleteBook;
            Books b = new Books(ss);
            scMain.SplitterPosition = b.Size.Width;
            b.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(b);
            Authors a = new Authors(new DataTable());
            scMain.Panel2.Enabled = true;
            a.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(a);
            ClearCheckDoCheck(btnDeleteBooks);
            rpgPrintingTool.Visible = false;
        }
        private void btnViewSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ViewSearch;
            Books b = new Books(ss);
            scMain.SplitterPosition = b.Size.Width;
            b.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(b);
            Authors a = new Authors(new DataTable());
            scMain.Panel2.Enabled = true;
            a.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(a);
            ClearCheckDoCheck(btnViewSearch);
            rpgPrintingTool.Visible = true;
        }
        private void btnSearchBorrowBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ViewSearch;
            Books b = new Books(ss);
            scMain.SplitterPosition = b.Size.Width;
            b.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(b);
            Authors a = new Authors(new DataTable());
            scMain.Panel2.Enabled = true;
            a.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(a);
            ClearCheckDoCheck(btnSearchBorrowBook);
            rpgBorrowerTools.Visible = false;
        }
        private void btnRegisterBorrower_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.RegisterBorrower;
            RegisterBorrower rb = new RegisterBorrower();
            scMain.SplitterPosition = 0;
            rb.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(rb);
            ClearCheckDoCheck(btnRegisterBorrower);
            rpgBorrowerTools.Visible = true;
        }
        
        private void btnBorrowSelected_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ss == SaveSender.ViewSearch)
            {
                rsc.BorrowNow(ss);
            }
        }
        
        private void btnApproveRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ApproveBorrower;
            scMain.SplitterPosition = 0;
            Borrowers b = new Borrowers(ss);
            b.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(b);
            ClearCheckDoCheck(btnApproveRegistration);
        }
        private void btnApproveBorrowerRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            ApproveForm();
        }
        private void ApproveForm()
        {
            ClearPanel();
            ss = SaveSender.ApproveBorrower;
            scMain.SplitterPosition = 0;
            Borrowers b = new Borrowers(ss);
            b.Dock = DockStyle.Fill;
            scMain.Panel2.Enabled = true;
            scMain.Panel2.Controls.Add(b);
            ClearCheckDoCheck(btnApproveBorrowerRegistration);
            rpgReceiveTools.Visible = false;
            rpgBorrowingTools.Visible = false;
            rpgBorrowingSave.Visible = true;
        }
        private void btnEditBorrower_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.EditBorrower;
            scMain.SplitterPosition = this.Size.Width;
            Borrowers b = new Borrowers(ss);
            b.Dock = DockStyle.Fill;
            scMain.Panel1.Enabled = true;
            scMain.Panel1.Controls.Add(b);
            ClearCheckDoCheck(btnEditBorrower);
        }
        private void btnCheckRequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.BorrowList;
            scMain.Panel2.Enabled = true;
            scMain.SplitterPosition = 0;
            BorrowedBooks bb = new BorrowedBooks(ss);
            bb.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(bb);
            ClearCheckDoCheck(btnCheckRequest);
            rpgReceiveTools.Visible = false;
            rpgBorrowingTools.Visible = true;
            rpgBorrowingSave.Visible = false;
        }
        private void btnReceiveReturns_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.ReceiveList;
            scMain.Panel2.Enabled = true;
            scMain.SplitterPosition = 0;
            BorrowedBooks bb = new BorrowedBooks(ss);
            bb.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(bb);
            ClearCheckDoCheck(btnReceiveReturns);
            rpgReceiveTools.Visible = true;
            rpgBorrowingTools.Visible = false;
            rpgBorrowingSave.Visible = false;
        }
        private void btnCheckTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.CheckTransactionRecord;
            scMain.Panel2.Enabled = true;
            scMain.SplitterPosition = 0;
            BorrowedBooks bb = new BorrowedBooks(ss);
            bb.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(bb);
            ClearCheckDoCheck(btnCheckTransaction);
            rpgReceiveTools.Visible = false;
            rpgBorrowingTools.Visible = false;
            rpgBorrowingSave.Visible = false;
        }
        private void btnCheckPenalties_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.CheckAndSanctionPenalty;
            scMain.Panel2.Enabled = true;
            scMain.SplitterPosition = 0;
            Penalties p = new Penalties(ss);
            p.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(p);
            ClearCheckDoCheck(btnCheckPenalties);
            rpgPenaltyTools.Visible = true;
        }
        private void btnCheckPenaltyStatistics_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearPanel();
            ss = SaveSender.CheckAllPenalties;
            scMain.Panel2.Enabled = true;
            scMain.SplitterPosition = 0;
            Penalties p = new Penalties(ss);
            p.Dock = DockStyle.Fill;
            scMain.Panel2.Controls.Add(p);
            ClearCheckDoCheck(btnCheckPenaltyStatistics);
            rpgPenaltyTools.Visible = false;
        }
        private void ClearCheckDoCheck(BarCheckItem itm)
        {
            foreach (BarItem c in ribTabs.Items)
            {
                if (c is BarCheckItem)
                {
                    ((BarCheckItem)c).Checked = false;
                }
            }
            if (itm != null)
            {
                itm.Checked = true;
            }
        }

        private void btnApproveRequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ss == SaveSender.BorrowList)
            {
                rsc.ApproveBorrow(true);
            }
        }

        private void btnRejectRequest_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ss == SaveSender.BorrowList)
            {
                rsc.ApproveBorrow(false);
            }
        }
        private void btnPrintCatalog_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ss == SaveSender.ViewSearch)
            {
                rsc.Print();
            }
        }
        private void btnReceiveSelected_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ss == SaveSender.ReceiveList)
            {
                rsc.ReceiveBookReturns();
            }
        }
    }
}
