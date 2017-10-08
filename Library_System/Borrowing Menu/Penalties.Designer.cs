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
            this.colDaysExceeded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateBorrowed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAllowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gpbCount = new DevExpress.XtraEditors.GroupControl();
            this.btnCount = new DevExpress.XtraEditors.SimpleButton();
            this.grpFilter = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpRFrom = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearhBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSearchKey = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPenaltyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbCount)).BeginInit();
            this.gpbCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFilter)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearhBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPenalty
            // 
            this.lstPenalty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPenalty.Location = new System.Drawing.Point(0, 101);
            this.lstPenalty.MainView = this.lstPenaltyItem;
            this.lstPenalty.Name = "lstPenalty";
            this.lstPenalty.Size = new System.Drawing.Size(1147, 382);
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
            this.colBorrowerName.Caption = "Borrowed By";
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
            // 
            // colReceiverName
            // 
            this.colReceiverName.Caption = "Received By";
            this.colReceiverName.FieldName = "rfullname";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.Visible = true;
            this.colReceiverName.VisibleIndex = 7;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 9;
            // 
            // colDaysExceeded
            // 
            this.colDaysExceeded.Caption = "Day(s) Exceeded";
            this.colDaysExceeded.FieldName = "daysExceed";
            this.colDaysExceeded.Name = "colDaysExceeded";
            this.colDaysExceeded.Visible = true;
            this.colDaysExceeded.VisibleIndex = 10;
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
            this.labelControl1.Location = new System.Drawing.Point(15, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // gpbCount
            // 
            this.gpbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCount.Controls.Add(this.btnCount);
            this.gpbCount.Location = new System.Drawing.Point(870, 101);
            this.gpbCount.Name = "gpbCount";
            this.gpbCount.Size = new System.Drawing.Size(277, 43);
            this.gpbCount.TabIndex = 42;
            this.gpbCount.Text = "Count Penalties(after Searching specific Borrower)";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(5, 17);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(267, 23);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count Now";
            this.btnCount.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.btnClear);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.dtpRTo);
            this.grpFilter.Controls.Add(this.dtpRFrom);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.cmbSearhBy);
            this.grpFilter.Controls.Add(this.txtSearchKey);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1147, 100);
            this.grpFilter.TabIndex = 44;
            this.grpFilter.Text = "Filter options";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(900, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(819, 24);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
            // 
            // dtpRTo
            // 
            this.dtpRTo.EditValue = null;
            this.dtpRTo.Location = new System.Drawing.Point(681, 26);
            this.dtpRTo.Name = "dtpRTo";
            this.dtpRTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRTo.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.dtpRTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpRTo.Size = new System.Drawing.Size(109, 20);
            this.dtpRTo.TabIndex = 9;
            // 
            // dtpRFrom
            // 
            this.dtpRFrom.EditValue = null;
            this.dtpRFrom.Location = new System.Drawing.Point(541, 26);
            this.dtpRFrom.Name = "dtpRFrom";
            this.dtpRFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRFrom.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.dtpRFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpRFrom.Size = new System.Drawing.Size(109, 20);
            this.dtpRFrom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Returned : From ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By: ";
            // 
            // cmbSearhBy
            // 
            this.cmbSearhBy.Location = new System.Drawing.Point(80, 52);
            this.cmbSearhBy.Name = "cmbSearhBy";
            this.cmbSearhBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearhBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSearhBy.Size = new System.Drawing.Size(293, 20);
            this.cmbSearhBy.TabIndex = 2;
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(80, 26);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(293, 20);
            this.txtSearchKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search : ";
            // 
            // Penalties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFilter);
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
            ((System.ComponentModel.ISupportInitialize)(this.grpFilter)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearhBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnCount;
        private DevExpress.XtraEditors.GroupControl grpFilter;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtpRTo;
        private DevExpress.XtraEditors.DateEdit dtpRFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSearhBy;
        private DevExpress.XtraEditors.TextEdit txtSearchKey;
        private System.Windows.Forms.Label label1;
    }
}
