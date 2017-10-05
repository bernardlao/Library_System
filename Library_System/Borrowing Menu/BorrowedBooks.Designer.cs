namespace Library_System.Borrowing_Menu
{
    partial class BorrowedBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBorrowed = new DevExpress.XtraGrid.GridControl();
            this.lstBorrowedItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowedBookID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateBorrowed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAllowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateReturned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibrarianID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibrarianID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpDateAllowance = new DevExpress.XtraEditors.GroupControl();
            this.txtDateAllowance = new DevExpress.XtraEditors.TextEdit();
            this.gpbLegends = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.colBookID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDateAllowance)).BeginInit();
            this.grpDateAllowance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateAllowance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbLegends)).BeginInit();
            this.gpbLegends.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBorrowed
            // 
            this.lstBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrowed.Location = new System.Drawing.Point(0, 0);
            this.lstBorrowed.MainView = this.lstBorrowedItem;
            this.lstBorrowed.Name = "lstBorrowed";
            this.lstBorrowed.Size = new System.Drawing.Size(1161, 480);
            this.lstBorrowed.TabIndex = 0;
            this.lstBorrowed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBorrowedItem});
            // 
            // lstBorrowedItem
            // 
            this.lstBorrowedItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colBookID,
            this.colBorrowedBookID,
            this.colCallNumber,
            this.colTitle,
            this.colBorrowerID,
            this.colBorrowerName,
            this.colQuantity,
            this.colDateBorrowed,
            this.colDateAllowance,
            this.colDateReturned,
            this.colLibrarianID1,
            this.colApproverName,
            this.colLibrarianID2,
            this.colReceiverName,
            this.colStatus});
            this.lstBorrowedItem.GridControl = this.lstBorrowed;
            this.lstBorrowedItem.Name = "lstBorrowedItem";
            this.lstBorrowedItem.OptionsBehavior.Editable = false;
            this.lstBorrowedItem.OptionsFind.AlwaysVisible = true;
            this.lstBorrowedItem.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.lstBorrowedItem_RowCellClick);
            this.lstBorrowedItem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.lstBorrowedItem_RowCellStyle);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            // 
            // colBorrowedBookID
            // 
            this.colBorrowedBookID.Caption = "ID";
            this.colBorrowedBookID.FieldName = "borrowedBookID";
            this.colBorrowedBookID.Name = "colBorrowedBookID";
            // 
            // colCallNumber
            // 
            this.colCallNumber.Caption = "Call Number";
            this.colCallNumber.FieldName = "callNumber";
            this.colCallNumber.Name = "colCallNumber";
            this.colCallNumber.Visible = true;
            this.colCallNumber.VisibleIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Book Title";
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 3;
            // 
            // colBorrowerID
            // 
            this.colBorrowerID.Caption = "Borrower ID";
            this.colBorrowerID.FieldName = "borrowerID";
            this.colBorrowerID.Name = "colBorrowerID";
            this.colBorrowerID.Visible = true;
            this.colBorrowerID.VisibleIndex = 4;
            // 
            // colBorrowerName
            // 
            this.colBorrowerName.Caption = "Borrower\'s Name";
            this.colBorrowerName.FieldName = "bfullname";
            this.colBorrowerName.Name = "colBorrowerName";
            this.colBorrowerName.Visible = true;
            this.colBorrowerName.VisibleIndex = 5;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            // 
            // colDateBorrowed
            // 
            this.colDateBorrowed.Caption = "Date Borrowed";
            this.colDateBorrowed.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm tt";
            this.colDateBorrowed.FieldName = "dateBorrowed";
            this.colDateBorrowed.Name = "colDateBorrowed";
            this.colDateBorrowed.Visible = true;
            this.colDateBorrowed.VisibleIndex = 7;
            // 
            // colDateAllowance
            // 
            this.colDateAllowance.Caption = "Date Allowance";
            this.colDateAllowance.FieldName = "dateAllowance";
            this.colDateAllowance.Name = "colDateAllowance";
            this.colDateAllowance.Visible = true;
            this.colDateAllowance.VisibleIndex = 8;
            // 
            // colDateReturned
            // 
            this.colDateReturned.Caption = "Date Returned";
            this.colDateReturned.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm tt";
            this.colDateReturned.FieldName = "dateReturned";
            this.colDateReturned.Name = "colDateReturned";
            this.colDateReturned.Visible = true;
            this.colDateReturned.VisibleIndex = 9;
            // 
            // colLibrarianID1
            // 
            this.colLibrarianID1.Caption = "Approver ID";
            this.colLibrarianID1.FieldName = "librarianID1";
            this.colLibrarianID1.Name = "colLibrarianID1";
            this.colLibrarianID1.Visible = true;
            this.colLibrarianID1.VisibleIndex = 10;
            // 
            // colApproverName
            // 
            this.colApproverName.Caption = "Approver\'s Name";
            this.colApproverName.FieldName = "afullname";
            this.colApproverName.Name = "colApproverName";
            this.colApproverName.Visible = true;
            this.colApproverName.VisibleIndex = 11;
            // 
            // colLibrarianID2
            // 
            this.colLibrarianID2.Caption = "Receiver ID";
            this.colLibrarianID2.FieldName = "librarianID2";
            this.colLibrarianID2.Name = "colLibrarianID2";
            this.colLibrarianID2.Visible = true;
            this.colLibrarianID2.VisibleIndex = 12;
            // 
            // colReceiverName
            // 
            this.colReceiverName.Caption = "Receiver\'s Name";
            this.colReceiverName.FieldName = "rfullname";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.Visible = true;
            this.colReceiverName.VisibleIndex = 13;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // grpDateAllowance
            // 
            this.grpDateAllowance.Controls.Add(this.txtDateAllowance);
            this.grpDateAllowance.Location = new System.Drawing.Point(505, 4);
            this.grpDateAllowance.Name = "grpDateAllowance";
            this.grpDateAllowance.Size = new System.Drawing.Size(201, 42);
            this.grpDateAllowance.TabIndex = 41;
            this.grpDateAllowance.Text = "Date Allowance";
            // 
            // txtDateAllowance
            // 
            this.txtDateAllowance.Location = new System.Drawing.Point(5, 18);
            this.txtDateAllowance.Name = "txtDateAllowance";
            this.txtDateAllowance.Properties.MaxLength = 2;
            this.txtDateAllowance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateAllowance.Size = new System.Drawing.Size(191, 20);
            this.txtDateAllowance.TabIndex = 0;
            this.txtDateAllowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateAllowance_KeyPress);
            // 
            // gpbLegends
            // 
            this.gpbLegends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbLegends.Controls.Add(this.labelControl7);
            this.gpbLegends.Controls.Add(this.labelControl6);
            this.gpbLegends.Controls.Add(this.labelControl5);
            this.gpbLegends.Controls.Add(this.labelControl4);
            this.gpbLegends.Controls.Add(this.labelControl3);
            this.gpbLegends.Controls.Add(this.labelControl2);
            this.gpbLegends.Location = new System.Drawing.Point(832, 4);
            this.gpbLegends.Name = "gpbLegends";
            this.gpbLegends.Size = new System.Drawing.Size(326, 42);
            this.gpbLegends.TabIndex = 42;
            this.gpbLegends.Text = "Legends";
            this.gpbLegends.Visible = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(289, 24);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "- Late";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(262, 24);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(20, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "RED";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(151, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "- Scheduled Return";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelControl4.Location = new System.Drawing.Point(104, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "YELLOW";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(40, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "- Not Late";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Location = new System.Drawing.Point(5, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "GREEN";
            // 
            // colBookID
            // 
            this.colBookID.Caption = "BookID";
            this.colBookID.FieldName = "bookID";
            this.colBookID.Name = "colBookID";
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbLegends);
            this.Controls.Add(this.grpDateAllowance);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstBorrowed);
            this.Name = "BorrowedBooks";
            this.Size = new System.Drawing.Size(1161, 480);
            this.Load += new System.EventHandler(this.BorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowedItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDateAllowance)).EndInit();
            this.grpDateAllowance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDateAllowance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbLegends)).EndInit();
            this.gpbLegends.ResumeLayout(false);
            this.gpbLegends.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstBorrowed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grpDateAllowance;
        private DevExpress.XtraEditors.TextEdit txtDateAllowance;
        private DevExpress.XtraGrid.Views.Grid.GridView lstBorrowedItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowedBookID;
        private DevExpress.XtraGrid.Columns.GridColumn colCallNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowerID;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDateBorrowed;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAllowance;
        private DevExpress.XtraGrid.Columns.GridColumn colDateReturned;
        private DevExpress.XtraGrid.Columns.GridColumn colLibrarianID1;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverName;
        private DevExpress.XtraGrid.Columns.GridColumn colLibrarianID2;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiverName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.GroupControl gpbLegends;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colBookID;
    }
}
