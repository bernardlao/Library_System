namespace Library_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribTabs = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnAddBook = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveBook = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddBooks = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewSearch = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveBooks = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelChanges = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckRequest = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveReturns = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckPenalties = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheckPenaltyStatus = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrowApprove = new DevExpress.XtraBars.BarButtonItem();
            this.btnRejectBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.btnReceiveReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegisterBorrower = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchBooks = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrowSelectedBook = new DevExpress.XtraBars.BarButtonItem();
            this.ribBooks = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBookManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBookModifier = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSubject = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBorrowing = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgManaging = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBorrowingTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgReceiveTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPenalty = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribManageAccounts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgManageAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAccountTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribBorrower = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBorrowerAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBorrowControl = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.scMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.tmDesigner = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribTabs
            // 
            this.ribTabs.ApplicationButtonDropDownControl = this.appMenu;
            this.ribTabs.ExpandCollapseItem.Id = 0;
            this.ribTabs.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribTabs.ExpandCollapseItem,
            this.btnAddBook,
            this.barButtonItem1,
            this.btnEditBook,
            this.btnDeleteBook,
            this.btnViewBook,
            this.btnSaveBook,
            this.barButtonItem2,
            this.btnAddBooks,
            this.btnViewSearch,
            this.btnSaveBooks,
            this.btnEdit,
            this.btnDelete,
            this.btnCancelChanges,
            this.btnSubject,
            this.btnCheckRequest,
            this.btnReceiveReturns,
            this.btnCheckPenalties,
            this.btnCheckPenaltyStatus,
            this.btnBorrowApprove,
            this.btnRejectBorrow,
            this.btnReceiveReturn,
            this.btnAddAccount,
            this.btnUpdateAccount,
            this.btnDeleteAccount,
            this.btnSaveAccount,
            this.btnViewAccounts,
            this.btnRegisterBorrower,
            this.barButtonItem3,
            this.btnSearchBooks,
            this.btnBorrowSelectedBook,
            this.btnLogout});
            this.ribTabs.Location = new System.Drawing.Point(0, 0);
            this.ribTabs.MaxItemId = 3;
            this.ribTabs.Name = "ribTabs";
            this.ribTabs.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribBooks,
            this.ribBorrowing,
            this.ribManageAccounts,
            this.ribBorrower});
            this.ribTabs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribTabs.ShowToolbarCustomizeItem = false;
            this.ribTabs.Size = new System.Drawing.Size(919, 143);
            this.ribTabs.Toolbar.ShowCustomizeItem = false;
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.btnLogout);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribTabs;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Caption = "Add Book";
            this.btnAddBook.Id = 1;
            this.btnAddBook.ImageUri.Uri = "Add";
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnEditBook
            // 
            this.btnEditBook.Caption = "Edit Book";
            this.btnEditBook.Id = 3;
            this.btnEditBook.ImageUri.Uri = "Edit";
            this.btnEditBook.Name = "btnEditBook";
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Caption = "Delete Book";
            this.btnDeleteBook.Id = 4;
            this.btnDeleteBook.ImageUri.Uri = "Cancel";
            this.btnDeleteBook.Name = "btnDeleteBook";
            // 
            // btnViewBook
            // 
            this.btnViewBook.Caption = "View Books";
            this.btnViewBook.Id = 5;
            this.btnViewBook.ImageUri.Uri = "Find";
            this.btnViewBook.Name = "btnViewBook";
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Caption = "Save";
            this.btnSaveBook.Id = 6;
            this.btnSaveBook.ImageUri.Uri = "Save";
            this.btnSaveBook.Name = "btnSaveBook";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Caption = "Add Books";
            this.btnAddBooks.Id = 8;
            this.btnAddBooks.ImageUri.Uri = "AddItem";
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnViewSearch
            // 
            this.btnViewSearch.Caption = "View and Search Books";
            this.btnViewSearch.Id = 9;
            this.btnViewSearch.ImageUri.Uri = "Zoom";
            this.btnViewSearch.Name = "btnViewSearch";
            // 
            // btnSaveBooks
            // 
            this.btnSaveBooks.Caption = "Save";
            this.btnSaveBooks.Id = 10;
            this.btnSaveBooks.ImageUri.Uri = "Save";
            this.btnSaveBooks.Name = "btnSaveBooks";
            this.btnSaveBooks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveBooks_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit Book";
            this.btnEdit.Id = 11;
            this.btnEdit.ImageUri.Uri = "Edit";
            this.btnEdit.Name = "btnEdit";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete Book(s)";
            this.btnDelete.Id = 12;
            this.btnDelete.ImageUri.Uri = "Cancel";
            this.btnDelete.Name = "btnDelete";
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.Caption = "Cancel Changes";
            this.btnCancelChanges.Id = 13;
            this.btnCancelChanges.ImageUri.Uri = "SaveAndClose";
            this.btnCancelChanges.Name = "btnCancelChanges";
            // 
            // btnSubject
            // 
            this.btnSubject.Caption = "Book Subject";
            this.btnSubject.Id = 14;
            this.btnSubject.ImageUri.Uri = "Strikeout";
            this.btnSubject.Name = "btnSubject";
            // 
            // btnCheckRequest
            // 
            this.btnCheckRequest.Caption = "Check Borrow Request";
            this.btnCheckRequest.Id = 15;
            this.btnCheckRequest.ImageUri.Uri = "Apply";
            this.btnCheckRequest.Name = "btnCheckRequest";
            // 
            // btnReceiveReturns
            // 
            this.btnReceiveReturns.Caption = "Receive Return(s)";
            this.btnReceiveReturns.Id = 16;
            this.btnReceiveReturns.ImageUri.Uri = "Reset";
            this.btnReceiveReturns.Name = "btnReceiveReturns";
            // 
            // btnCheckPenalties
            // 
            this.btnCheckPenalties.Caption = "Check Penalty Statistics";
            this.btnCheckPenalties.Id = 17;
            this.btnCheckPenalties.ImageUri.Uri = "Chart";
            this.btnCheckPenalties.Name = "btnCheckPenalties";
            // 
            // btnCheckPenaltyStatus
            // 
            this.btnCheckPenaltyStatus.Caption = "Check Penalty";
            this.btnCheckPenaltyStatus.Id = 18;
            this.btnCheckPenaltyStatus.ImageUri.Uri = "Chart";
            this.btnCheckPenaltyStatus.Name = "btnCheckPenaltyStatus";
            // 
            // btnBorrowApprove
            // 
            this.btnBorrowApprove.Caption = "Approve";
            this.btnBorrowApprove.Id = 19;
            this.btnBorrowApprove.ImageUri.Uri = "Apply";
            this.btnBorrowApprove.Name = "btnBorrowApprove";
            // 
            // btnRejectBorrow
            // 
            this.btnRejectBorrow.Caption = "Reject";
            this.btnRejectBorrow.Id = 20;
            this.btnRejectBorrow.ImageUri.Uri = "Delete";
            this.btnRejectBorrow.Name = "btnRejectBorrow";
            // 
            // btnReceiveReturn
            // 
            this.btnReceiveReturn.Caption = "Receive Selected";
            this.btnReceiveReturn.Id = 21;
            this.btnReceiveReturn.ImageUri.Uri = "Squeeze";
            this.btnReceiveReturn.Name = "btnReceiveReturn";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Caption = "Add Account";
            this.btnAddAccount.Id = 22;
            this.btnAddAccount.ImageUri.Uri = "Add";
            this.btnAddAccount.Name = "btnAddAccount";
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Caption = "Update Account";
            this.btnUpdateAccount.Id = 23;
            this.btnUpdateAccount.ImageUri.Uri = "Edit";
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Caption = "Delete Account";
            this.btnDeleteAccount.Id = 24;
            this.btnDeleteAccount.ImageUri.Uri = "Cut";
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Caption = "Save";
            this.btnSaveAccount.Id = 25;
            this.btnSaveAccount.ImageUri.Uri = "Save";
            this.btnSaveAccount.Name = "btnSaveAccount";
            // 
            // btnViewAccounts
            // 
            this.btnViewAccounts.Caption = "View Accounts";
            this.btnViewAccounts.Id = 26;
            this.btnViewAccounts.ImageUri.Uri = "Find";
            this.btnViewAccounts.Name = "btnViewAccounts";
            // 
            // btnRegisterBorrower
            // 
            this.btnRegisterBorrower.Caption = "Register";
            this.btnRegisterBorrower.Id = 27;
            this.btnRegisterBorrower.ImageUri.Uri = "AddItem";
            this.btnRegisterBorrower.Name = "btnRegisterBorrower";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 28;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Caption = "Search Book";
            this.btnSearchBooks.Id = 29;
            this.btnSearchBooks.ImageUri.Uri = "Zoom";
            this.btnSearchBooks.Name = "btnSearchBooks";
            // 
            // btnBorrowSelectedBook
            // 
            this.btnBorrowSelectedBook.Caption = "Borrow Selected Book";
            this.btnBorrowSelectedBook.Id = 30;
            this.btnBorrowSelectedBook.ImageUri.Uri = "Up";
            this.btnBorrowSelectedBook.Name = "btnBorrowSelectedBook";
            // 
            // ribBooks
            // 
            this.ribBooks.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBookManager,
            this.rpgBookModifier,
            this.rpgSubject,
            this.rpgTools});
            this.ribBooks.Name = "ribBooks";
            this.ribBooks.Text = "Manage Books";
            // 
            // rpgBookManager
            // 
            this.rpgBookManager.ItemLinks.Add(this.btnAddBooks);
            this.rpgBookManager.ItemLinks.Add(this.btnViewSearch);
            this.rpgBookManager.Name = "rpgBookManager";
            this.rpgBookManager.Text = "Book Manager";
            // 
            // rpgBookModifier
            // 
            this.rpgBookModifier.ItemLinks.Add(this.btnEdit);
            this.rpgBookModifier.ItemLinks.Add(this.btnDelete);
            this.rpgBookModifier.Name = "rpgBookModifier";
            this.rpgBookModifier.Text = "Book Modifier";
            // 
            // rpgSubject
            // 
            this.rpgSubject.ItemLinks.Add(this.btnSubject);
            this.rpgSubject.Name = "rpgSubject";
            this.rpgSubject.Text = "Subject";
            // 
            // rpgTools
            // 
            this.rpgTools.ItemLinks.Add(this.btnSaveBooks);
            this.rpgTools.ItemLinks.Add(this.btnCancelChanges);
            this.rpgTools.Name = "rpgTools";
            this.rpgTools.Text = "Book Tools";
            // 
            // ribBorrowing
            // 
            this.ribBorrowing.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgManaging,
            this.rpgBorrowingTools,
            this.rpgReceiveTools,
            this.rpgPenalty});
            this.ribBorrowing.Name = "ribBorrowing";
            this.ribBorrowing.Text = "Borrowing Options";
            // 
            // rpgManaging
            // 
            this.rpgManaging.ItemLinks.Add(this.btnCheckRequest);
            this.rpgManaging.ItemLinks.Add(this.btnReceiveReturns);
            this.rpgManaging.Name = "rpgManaging";
            this.rpgManaging.Text = "Manage In/Out";
            // 
            // rpgBorrowingTools
            // 
            this.rpgBorrowingTools.ItemLinks.Add(this.btnBorrowApprove);
            this.rpgBorrowingTools.ItemLinks.Add(this.btnRejectBorrow);
            this.rpgBorrowingTools.Name = "rpgBorrowingTools";
            this.rpgBorrowingTools.Text = "Borrowing Tools";
            // 
            // rpgReceiveTools
            // 
            this.rpgReceiveTools.AllowTextClipping = false;
            this.rpgReceiveTools.ItemLinks.Add(this.btnReceiveReturn);
            this.rpgReceiveTools.Name = "rpgReceiveTools";
            this.rpgReceiveTools.Text = "Receiving Tools";
            // 
            // rpgPenalty
            // 
            this.rpgPenalty.ItemLinks.Add(this.btnCheckPenaltyStatus);
            this.rpgPenalty.ItemLinks.Add(this.btnCheckPenalties);
            this.rpgPenalty.Name = "rpgPenalty";
            this.rpgPenalty.Text = "Penalties";
            // 
            // ribManageAccounts
            // 
            this.ribManageAccounts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgManageAccount,
            this.rpgAccountTools});
            this.ribManageAccounts.Name = "ribManageAccounts";
            this.ribManageAccounts.Text = "Manage Accounts";
            // 
            // rpgManageAccount
            // 
            this.rpgManageAccount.ItemLinks.Add(this.btnAddAccount);
            this.rpgManageAccount.ItemLinks.Add(this.btnUpdateAccount);
            this.rpgManageAccount.ItemLinks.Add(this.btnDeleteAccount);
            this.rpgManageAccount.Name = "rpgManageAccount";
            this.rpgManageAccount.Text = "Manage Account";
            // 
            // rpgAccountTools
            // 
            this.rpgAccountTools.ItemLinks.Add(this.btnSaveAccount);
            this.rpgAccountTools.ItemLinks.Add(this.btnViewAccounts);
            this.rpgAccountTools.Name = "rpgAccountTools";
            this.rpgAccountTools.Text = "Tools";
            // 
            // ribBorrower
            // 
            this.ribBorrower.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBorrowerAccount,
            this.rpgBorrowControl});
            this.ribBorrower.Name = "ribBorrower";
            this.ribBorrower.Text = "Borrower\'s Menu";
            // 
            // rpgBorrowerAccount
            // 
            this.rpgBorrowerAccount.AllowTextClipping = false;
            this.rpgBorrowerAccount.ItemLinks.Add(this.btnRegisterBorrower);
            this.rpgBorrowerAccount.Name = "rpgBorrowerAccount";
            this.rpgBorrowerAccount.Text = "Accounts";
            // 
            // rpgBorrowControl
            // 
            this.rpgBorrowControl.ItemLinks.Add(this.btnSearchBooks);
            this.rpgBorrowControl.ItemLinks.Add(this.btnBorrowSelectedBook);
            this.rpgBorrowControl.Name = "rpgBorrowControl";
            this.rpgBorrowControl.Text = "Borrow Control";
            // 
            // scMain
            // 
            this.scMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 143);
            this.scMain.Name = "scMain";
            this.scMain.Panel1.Text = "Panel1";
            this.scMain.Panel2.AutoScroll = true;
            this.scMain.Panel2.Text = "Panel2";
            this.scMain.Size = new System.Drawing.Size(919, 328);
            this.scMain.SplitterPosition = 438;
            this.scMain.TabIndex = 1;
            this.scMain.Text = "splitContainerControl1";
            // 
            // tmDesigner
            // 
            this.tmDesigner.Enabled = true;
            this.tmDesigner.Tick += new System.EventHandler(this.tmDesigner_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.Id = 2;
            this.btnLogout.ImageUri.Uri = "Show";
            this.btnLogout.Name = "btnLogout";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 471);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.ribTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Ribbon = this.ribTabs;
            this.Text = "Library System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribTabs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBooks;
        private DevExpress.XtraBars.BarButtonItem btnAddBook;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnEditBook;
        private DevExpress.XtraBars.BarButtonItem btnDeleteBook;
        private DevExpress.XtraBars.BarButtonItem btnViewBook;
        private DevExpress.XtraBars.BarButtonItem btnSaveBook;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBookManager;
        private DevExpress.XtraBars.BarButtonItem btnAddBooks;
        private DevExpress.XtraBars.BarButtonItem btnViewSearch;
        private DevExpress.XtraBars.BarButtonItem btnSaveBooks;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCancelChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTools;
        private DevExpress.XtraBars.BarButtonItem btnSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSubject;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBorrowing;
        private DevExpress.XtraBars.BarButtonItem btnCheckRequest;
        private DevExpress.XtraBars.BarButtonItem btnReceiveReturns;
        private DevExpress.XtraBars.BarButtonItem btnCheckPenalties;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManaging;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPenalty;
        private DevExpress.XtraBars.BarButtonItem btnCheckPenaltyStatus;
        private DevExpress.XtraBars.BarButtonItem btnBorrowApprove;
        private DevExpress.XtraBars.BarButtonItem btnRejectBorrow;
        private DevExpress.XtraBars.BarButtonItem btnReceiveReturn;
        private DevExpress.XtraBars.BarButtonItem btnAddAccount;
        private DevExpress.XtraBars.BarButtonItem btnUpdateAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowingTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgReceiveTools;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribManageAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgManageAccount;
        private DevExpress.XtraBars.BarButtonItem btnDeleteAccount;
        private DevExpress.XtraBars.BarButtonItem btnSaveAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAccountTools;
        private DevExpress.XtraBars.BarButtonItem btnViewAccounts;
        private DevExpress.XtraBars.BarButtonItem btnRegisterBorrower;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribBorrower;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowerAccount;
        private DevExpress.XtraBars.BarButtonItem btnSearchBooks;
        private DevExpress.XtraBars.BarButtonItem btnBorrowSelectedBook;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBorrowControl;
        private System.Windows.Forms.Timer tmDesigner;
        public DevExpress.XtraEditors.SplitContainerControl scMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBookModifier;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
    }
}

