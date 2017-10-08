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
            this.colBookID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowedBookID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateBorrowed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAllowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScheduledReturn = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.grpFilter = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearhBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSearchKey = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBFrom = new DevExpress.XtraEditors.DateEdit();
            this.dtpBTo = new DevExpress.XtraEditors.DateEdit();
            this.dtpRFrom = new DevExpress.XtraEditors.DateEdit();
            this.dtpRTo = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowedItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDateAllowance)).BeginInit();
            this.grpDateAllowance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateAllowance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbLegends)).BeginInit();
            this.gpbLegends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFilter)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearhBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBorrowed
            // 
            this.lstBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBorrowed.Location = new System.Drawing.Point(0, 102);
            this.lstBorrowed.MainView = this.lstBorrowedItem;
            this.lstBorrowed.Name = "lstBorrowed";
            this.lstBorrowed.Size = new System.Drawing.Size(1161, 378);
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
            this.colScheduledReturn,
            this.colDateReturned,
            this.colLibrarianID1,
            this.colApproverName,
            this.colLibrarianID2,
            this.colReceiverName,
            this.colStatus});
            this.lstBorrowedItem.GridControl = this.lstBorrowed;
            this.lstBorrowedItem.Name = "lstBorrowedItem";
            this.lstBorrowedItem.OptionsBehavior.Editable = false;
            this.lstBorrowedItem.OptionsBehavior.ImmediateUpdateRowPosition = false;
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
            // colBookID
            // 
            this.colBookID.Caption = "BookID";
            this.colBookID.FieldName = "bookID";
            this.colBookID.Name = "colBookID";
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
            this.colCallNumber.VisibleIndex = 1;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Book Title";
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            // 
            // colBorrowerID
            // 
            this.colBorrowerID.Caption = "Borrower ID";
            this.colBorrowerID.FieldName = "borrowerID";
            this.colBorrowerID.Name = "colBorrowerID";
            this.colBorrowerID.Visible = true;
            this.colBorrowerID.VisibleIndex = 3;
            // 
            // colBorrowerName
            // 
            this.colBorrowerName.Caption = "Borrowed By";
            this.colBorrowerName.FieldName = "bfullname";
            this.colBorrowerName.Name = "colBorrowerName";
            this.colBorrowerName.Visible = true;
            this.colBorrowerName.VisibleIndex = 4;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // colDateBorrowed
            // 
            this.colDateBorrowed.Caption = "Date Borrowed";
            this.colDateBorrowed.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm tt";
            this.colDateBorrowed.FieldName = "dateBorrowed";
            this.colDateBorrowed.Name = "colDateBorrowed";
            this.colDateBorrowed.Visible = true;
            this.colDateBorrowed.VisibleIndex = 6;
            // 
            // colDateAllowance
            // 
            this.colDateAllowance.Caption = "Day(s) Allowed";
            this.colDateAllowance.FieldName = "dateAllowance";
            this.colDateAllowance.Name = "colDateAllowance";
            this.colDateAllowance.Visible = true;
            this.colDateAllowance.VisibleIndex = 7;
            // 
            // colScheduledReturn
            // 
            this.colScheduledReturn.Caption = "Scheduled Return";
            this.colScheduledReturn.DisplayFormat.FormatString = "MM/dd/yyyy";
            this.colScheduledReturn.FieldName = "scheduledReturn";
            this.colScheduledReturn.Name = "colScheduledReturn";
            this.colScheduledReturn.Visible = true;
            this.colScheduledReturn.VisibleIndex = 8;
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
            // 
            // colApproverName
            // 
            this.colApproverName.Caption = "Approved By";
            this.colApproverName.FieldName = "afullname";
            this.colApproverName.Name = "colApproverName";
            this.colApproverName.Visible = true;
            this.colApproverName.VisibleIndex = 10;
            // 
            // colLibrarianID2
            // 
            this.colLibrarianID2.Caption = "Receiver ID";
            this.colLibrarianID2.FieldName = "librarianID2";
            this.colLibrarianID2.Name = "colLibrarianID2";
            // 
            // colReceiverName
            // 
            this.colReceiverName.Caption = "Received By";
            this.colReceiverName.FieldName = "rfullname";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.Visible = true;
            this.colReceiverName.VisibleIndex = 11;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // grpDateAllowance
            // 
            this.grpDateAllowance.Controls.Add(this.txtDateAllowance);
            this.grpDateAllowance.Location = new System.Drawing.Point(499, 102);
            this.grpDateAllowance.Name = "grpDateAllowance";
            this.grpDateAllowance.Size = new System.Drawing.Size(201, 42);
            this.grpDateAllowance.TabIndex = 41;
            this.grpDateAllowance.Text = "Date Allowance";
            // 
            // txtDateAllowance
            // 
            this.txtDateAllowance.EditValue = "1";
            this.txtDateAllowance.Location = new System.Drawing.Point(5, 21);
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
            this.gpbLegends.Location = new System.Drawing.Point(835, 102);
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
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Controls.Add(this.btnClear);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.dtpRTo);
            this.grpFilter.Controls.Add(this.dtpRFrom);
            this.grpFilter.Controls.Add(this.dtpBTo);
            this.grpFilter.Controls.Add(this.dtpBFrom);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.cmbSearhBy);
            this.grpFilter.Controls.Add(this.txtSearchKey);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1161, 100);
            this.grpFilter.TabIndex = 43;
            this.grpFilter.Text = "Filter options";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Borrowed : From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Returned : From ";
            // 
            // dtpBFrom
            // 
            this.dtpBFrom.EditValue = null;
            this.dtpBFrom.Location = new System.Drawing.Point(543, 26);
            this.dtpBFrom.Name = "dtpBFrom";
            this.dtpBFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBFrom.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.dtpBFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBFrom.Size = new System.Drawing.Size(109, 20);
            this.dtpBFrom.TabIndex = 6;
            // 
            // dtpBTo
            // 
            this.dtpBTo.EditValue = null;
            this.dtpBTo.Location = new System.Drawing.Point(683, 26);
            this.dtpBTo.Name = "dtpBTo";
            this.dtpBTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBTo.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
            this.dtpBTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBTo.Size = new System.Drawing.Size(109, 20);
            this.dtpBTo.TabIndex = 7;
            // 
            // dtpRFrom
            // 
            this.dtpRFrom.EditValue = null;
            this.dtpRFrom.Location = new System.Drawing.Point(543, 52);
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
            // dtpRTo
            // 
            this.dtpRTo.EditValue = null;
            this.dtpRTo.Location = new System.Drawing.Point(683, 52);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "To";
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(819, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpFilter);
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
            ((System.ComponentModel.ISupportInitialize)(this.grpFilter)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearhBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRTo.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colScheduledReturn;
        private DevExpress.XtraEditors.GroupControl grpFilter;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSearhBy;
        private DevExpress.XtraEditors.TextEdit txtSearchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtpRTo;
        private DevExpress.XtraEditors.DateEdit dtpRFrom;
        private DevExpress.XtraEditors.DateEdit dtpBTo;
        private DevExpress.XtraEditors.DateEdit dtpBFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.SimpleButton btnClear;
    }
}
