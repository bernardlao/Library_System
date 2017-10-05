namespace Library_System.Borrowing_Menu
{
    partial class Penalties
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
            this.lstPenalty = new DevExpress.XtraGrid.GridControl();
            this.lstPenaltyItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPenaltyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateReturned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibrarianID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateBorrowed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAllowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colDaysExceeded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gpbCount = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPenaltyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbCount)).BeginInit();
            this.gpbCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPenalty
            // 
            this.lstPenalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPenalty.Location = new System.Drawing.Point(0, 0);
            this.lstPenalty.MainView = this.lstPenaltyItem;
            this.lstPenalty.Name = "lstPenalty";
            this.lstPenalty.Size = new System.Drawing.Size(1147, 483);
            this.lstPenalty.TabIndex = 0;
            this.lstPenalty.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstPenaltyItem});
            // 
            // lstPenaltyItem
            // 
            this.lstPenaltyItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colPenaltyID,
            this.colBorrowerID,
            this.colBorrowerName,
            this.colCallNumber,
            this.colTitle,
            this.colQuantity,
            this.colDateReturned,
            this.colLibrarianID,
            this.colReceiverName,
            this.colStatus,
            this.colDaysExceeded,
            this.colDateBorrowed,
            this.colDateAllowance});
            this.lstPenaltyItem.GridControl = this.lstPenalty;
            this.lstPenaltyItem.Name = "lstPenaltyItem";
            this.lstPenaltyItem.OptionsBehavior.Editable = false;
            this.lstPenaltyItem.OptionsFind.AlwaysVisible = true;
            this.lstPenaltyItem.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.lstPenaltyItem_RowCellClick);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.OptionsColumn.FixedWidth = true;
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            this.colIsSelected.Width = 50;
            // 
            // colPenaltyID
            // 
            this.colPenaltyID.Caption = "ID";
            this.colPenaltyID.FieldName = "penaltyID";
            this.colPenaltyID.Name = "colPenaltyID";
            // 
            // colBorrowerID
            // 
            this.colBorrowerID.Caption = "Borrower ID";
            this.colBorrowerID.FieldName = "borrowerID";
            this.colBorrowerID.Name = "colBorrowerID";
            this.colBorrowerID.Visible = true;
            this.colBorrowerID.VisibleIndex = 1;
            // 
            // colBorrowerName
            // 
            this.colBorrowerName.Caption = "Borrower\'s Name";
            this.colBorrowerName.FieldName = "bfullname";
            this.colBorrowerName.Name = "colBorrowerName";
            this.colBorrowerName.Visible = true;
            this.colBorrowerName.VisibleIndex = 2;
            // 
            // colCallNumber
            // 
            this.colCallNumber.Caption = "Call Number";
            this.colCallNumber.FieldName = "callNumber";
            this.colCallNumber.Name = "colCallNumber";
            this.colCallNumber.Visible = true;
            this.colCallNumber.VisibleIndex = 3;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Book Title";
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 4;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colDateReturned
            // 
            this.colDateReturned.Caption = "Date Returned";
            this.colDateReturned.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm tt";
            this.colDateReturned.FieldName = "dateReturned";
            this.colDateReturned.Name = "colDateReturned";
            this.colDateReturned.Visible = true;
            this.colDateReturned.VisibleIndex = 6;
            // 
            // colLibrarianID
            // 
            this.colLibrarianID.Caption = "Receiver ID";
            this.colLibrarianID.FieldName = "librarianID";
            this.colLibrarianID.Name = "colLibrarianID";
            this.colLibrarianID.Visible = true;
            this.colLibrarianID.VisibleIndex = 7;
            // 
            // colReceiverName
            // 
            this.colReceiverName.Caption = "Receiver\'s Name";
            this.colReceiverName.FieldName = "rfullname";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.Visible = true;
            this.colReceiverName.VisibleIndex = 8;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 9;
            // 
            // colDateBorrowed
            // 
            this.colDateBorrowed.Caption = "Date Borrowed";
            this.colDateBorrowed.FieldName = "dateBorrowed";
            this.colDateBorrowed.Name = "colDateBorrowed";
            // 
            // colDateAllowance
            // 
            this.colDateAllowance.Caption = "Date Allowance";
            this.colDateAllowance.FieldName = "dateAllowance";
            this.colDateAllowance.Name = "colDateAllowance";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // colDaysExceeded
            // 
            this.colDaysExceeded.Caption = "Day(s) Exceeded";
            this.colDaysExceeded.FieldName = "daysExceed";
            this.colDaysExceeded.Name = "colDaysExceeded";
            this.colDaysExceeded.Visible = true;
            this.colDaysExceeded.VisibleIndex = 10;
            // 
            // gpbCount
            // 
            this.gpbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCount.Controls.Add(this.simpleButton1);
            this.gpbCount.Location = new System.Drawing.Point(867, 3);
            this.gpbCount.Name = "gpbCount";
            this.gpbCount.Size = new System.Drawing.Size(277, 43);
            this.gpbCount.TabIndex = 42;
            this.gpbCount.Text = "Count Penalties(after Searching specific Borrower)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(267, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Count Now";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbCount);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstPenalty);
            this.Name = "Penalties";
            this.Size = new System.Drawing.Size(1147, 483);
            this.Load += new System.EventHandler(this.Penalties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPenaltyItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbCount)).EndInit();
            this.gpbCount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstPenalty;
        private DevExpress.XtraGrid.Views.Grid.GridView lstPenaltyItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colPenaltyID;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowerID;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCallNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDateReturned;
        private DevExpress.XtraGrid.Columns.GridColumn colLibrarianID;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiverName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDateBorrowed;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAllowance;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colDaysExceeded;
        private DevExpress.XtraEditors.GroupControl gpbCount;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
