namespace Library_System.Borrowing_Menu
{
    partial class LogsList
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
            this.gpbFilter = new DevExpress.XtraEditors.GroupControl();
            this.cmbSearchBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.txtLoggedInUserID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lstLogs = new DevExpress.XtraGrid.GridControl();
            this.lstLogsItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoggedInID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogTable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gpbFilter)).BeginInit();
            this.gpbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoggedInUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLogsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFilter
            // 
            this.gpbFilter.Controls.Add(this.cmbSearchBy);
            this.gpbFilter.Controls.Add(this.simpleButton1);
            this.gpbFilter.Controls.Add(this.btnFilter);
            this.gpbFilter.Controls.Add(this.txtLoggedInUserID);
            this.gpbFilter.Controls.Add(this.labelControl5);
            this.gpbFilter.Controls.Add(this.dtpTo);
            this.gpbFilter.Controls.Add(this.labelControl4);
            this.gpbFilter.Controls.Add(this.dtpFrom);
            this.gpbFilter.Controls.Add(this.labelControl3);
            this.gpbFilter.Controls.Add(this.cmbType);
            this.gpbFilter.Controls.Add(this.labelControl2);
            this.gpbFilter.Controls.Add(this.cmbField);
            this.gpbFilter.Controls.Add(this.labelControl1);
            this.gpbFilter.Location = new System.Drawing.Point(1, 1);
            this.gpbFilter.Name = "gpbFilter";
            this.gpbFilter.Size = new System.Drawing.Size(1036, 103);
            this.gpbFilter.TabIndex = 0;
            this.gpbFilter.Text = "Filter Options";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Location = new System.Drawing.Point(316, 63);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearchBy.Properties.Items.AddRange(new object[] {
            "ID",
            "Fullname"});
            this.cmbSearchBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbSearchBy.Size = new System.Drawing.Size(92, 20);
            this.cmbSearchBy.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(569, 61);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Clear Filter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(430, 61);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 23);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtLoggedInUserID
            // 
            this.txtLoggedInUserID.Location = new System.Drawing.Point(115, 63);
            this.txtLoggedInUserID.Name = "txtLoggedInUserID";
            this.txtLoggedInUserID.Size = new System.Drawing.Size(179, 20);
            this.txtLoggedInUserID.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 66);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Additional Filter :";
            // 
            // dtpTo
            // 
            this.dtpTo.EditValue = null;
            this.dtpTo.Location = new System.Drawing.Point(829, 31);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpTo.Size = new System.Drawing.Size(100, 20);
            this.dtpTo.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(811, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.EditValue = null;
            this.dtpFrom.Location = new System.Drawing.Point(705, 31);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(615, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Date Span From :";
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(405, 31);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Properties.Items.AddRange(new object[] {
            "All",
            "Add/Register",
            "Update",
            "Delete"});
            this.cmbType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbType.Size = new System.Drawing.Size(188, 20);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(316, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Type of Activity :";
            // 
            // cmbField
            // 
            this.cmbField.Location = new System.Drawing.Point(115, 31);
            this.cmbField.Name = "cmbField";
            this.cmbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbField.Properties.Items.AddRange(new object[] {
            "All",
            "Users",
            "Login/Logout",
            "Borrowers",
            "Books",
            "Subjects",
            "Publishers",
            "Authors",
            "Penalty Sanctions"});
            this.cmbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbField.Size = new System.Drawing.Size(179, 20);
            this.cmbField.TabIndex = 1;
            this.cmbField.SelectedIndexChanged += new System.EventHandler(this.cmbField_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Activity Field :";
            // 
            // lstLogs
            // 
            this.lstLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLogs.Location = new System.Drawing.Point(-2, 107);
            this.lstLogs.MainView = this.lstLogsItem;
            this.lstLogs.Name = "lstLogs";
            this.lstLogs.Size = new System.Drawing.Size(1039, 382);
            this.lstLogs.TabIndex = 1;
            this.lstLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstLogsItem});
            // 
            // lstLogsItem
            // 
            this.lstLogsItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogID,
            this.colUserID,
            this.colLoggedInID,
            this.colFullname,
            this.colLogTable,
            this.colLogType,
            this.colLogDescription,
            this.colLogDate});
            this.lstLogsItem.GridControl = this.lstLogs;
            this.lstLogsItem.Name = "lstLogsItem";
            this.lstLogsItem.OptionsBehavior.Editable = false;
            this.lstLogsItem.OptionsFind.AlwaysVisible = true;
            this.lstLogsItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lstLogsItem.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.lstLogsItem_RowCellClick);
            // 
            // colLogID
            // 
            this.colLogID.Caption = "Log ID";
            this.colLogID.FieldName = "logID";
            this.colLogID.Name = "colLogID";
            // 
            // colUserID
            // 
            this.colUserID.Caption = "User ID";
            this.colUserID.FieldName = "userID";
            this.colUserID.Name = "colUserID";
            // 
            // colLoggedInID
            // 
            this.colLoggedInID.Caption = "Logged in ID";
            this.colLoggedInID.FieldName = "librarianID";
            this.colLoggedInID.Name = "colLoggedInID";
            this.colLoggedInID.Visible = true;
            this.colLoggedInID.VisibleIndex = 0;
            // 
            // colFullname
            // 
            this.colFullname.Caption = "Fullname";
            this.colFullname.FieldName = "fullname";
            this.colFullname.Name = "colFullname";
            this.colFullname.Visible = true;
            this.colFullname.VisibleIndex = 1;
            // 
            // colLogTable
            // 
            this.colLogTable.Caption = "Log Table";
            this.colLogTable.FieldName = "logTable";
            this.colLogTable.Name = "colLogTable";
            // 
            // colLogType
            // 
            this.colLogType.Caption = "Log Type";
            this.colLogType.FieldName = "logType";
            this.colLogType.Name = "colLogType";
            // 
            // colLogDescription
            // 
            this.colLogDescription.Caption = "Description";
            this.colLogDescription.FieldName = "logDescription";
            this.colLogDescription.Name = "colLogDescription";
            this.colLogDescription.Visible = true;
            this.colLogDescription.VisibleIndex = 2;
            // 
            // colLogDate
            // 
            this.colLogDate.Caption = "Date";
            this.colLogDate.DisplayFormat.FormatString = "MMMM dd, yyyy hh:mm tt";
            this.colLogDate.FieldName = "logDate";
            this.colLogDate.Name = "colLogDate";
            this.colLogDate.Visible = true;
            this.colLogDate.VisibleIndex = 3;
            // 
            // LogsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.gpbFilter);
            this.Name = "LogsList";
            this.Size = new System.Drawing.Size(1035, 487);
            this.Load += new System.EventHandler(this.LogsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpbFilter)).EndInit();
            this.gpbFilter.ResumeLayout(false);
            this.gpbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoggedInUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstLogsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpbFilter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbField;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbType;
        private DevExpress.XtraEditors.DateEdit dtpTo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtpFrom;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.TextEdit txtLoggedInUserID;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl lstLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView lstLogsItem;
        private DevExpress.XtraGrid.Columns.GridColumn colLogID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colLoggedInID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname;
        private DevExpress.XtraGrid.Columns.GridColumn colLogTable;
        private DevExpress.XtraGrid.Columns.GridColumn colLogDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLogDate;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSearchBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLogType;
    }
}
