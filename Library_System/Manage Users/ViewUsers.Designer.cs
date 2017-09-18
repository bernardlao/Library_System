namespace Library_System.Manage_Users
{
    partial class viewUsers
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
            this.lstUsers = new DevExpress.XtraGrid.GridControl();
            this.lstUsersItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibrarianID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsersItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.Location = new System.Drawing.Point(0, 0);
            this.lstUsers.MainView = this.lstUsersItem;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(873, 503);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstUsersItem});
            // 
            // lstUsersItem
            // 
            this.lstUsersItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colUserID,
            this.colUsername,
            this.colLibrarianID,
            this.colFirstname,
            this.colMiddlename,
            this.colLastname,
            this.colIsEdited});
            this.lstUsersItem.GridControl = this.lstUsers;
            this.lstUsersItem.Name = "lstUsersItem";
            this.lstUsersItem.OptionsFind.AlwaysVisible = true;
            this.lstUsersItem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.lstUsersItem_RowCellStyle);
            this.lstUsersItem.ShownEditor += new System.EventHandler(this.lstUsersItem_ShownEditor);
            this.lstUsersItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstUsersItem_CellValueChanged);
            this.lstUsersItem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstUsersItem_CellValueChanging);
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Selected";
            this.colSelected.FieldName = "isSelected";
            this.colSelected.Name = "colSelected";
            // 
            // colUserID
            // 
            this.colUserID.Caption = "User ID";
            this.colUserID.FieldName = "userID";
            this.colUserID.Name = "colUserID";
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Username";
            this.colUsername.FieldName = "username";
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 0;
            // 
            // colLibrarianID
            // 
            this.colLibrarianID.Caption = "Librarian ID";
            this.colLibrarianID.FieldName = "librarianID";
            this.colLibrarianID.Name = "colLibrarianID";
            this.colLibrarianID.Visible = true;
            this.colLibrarianID.VisibleIndex = 1;
            // 
            // colFirstname
            // 
            this.colFirstname.Caption = "Firstname";
            this.colFirstname.FieldName = "fname";
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.Visible = true;
            this.colFirstname.VisibleIndex = 2;
            // 
            // colMiddlename
            // 
            this.colMiddlename.Caption = "Middlename/Initial";
            this.colMiddlename.FieldName = "mname";
            this.colMiddlename.Name = "colMiddlename";
            this.colMiddlename.Visible = true;
            this.colMiddlename.VisibleIndex = 3;
            // 
            // colLastname
            // 
            this.colLastname.Caption = "Lastname";
            this.colLastname.FieldName = "lname";
            this.colLastname.Name = "colLastname";
            this.colLastname.Visible = true;
            this.colLastname.VisibleIndex = 4;
            // 
            // colIsEdited
            // 
            this.colIsEdited.Caption = "isEdited";
            this.colIsEdited.FieldName = "isEdited";
            this.colIsEdited.Name = "colIsEdited";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // viewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstUsers);
            this.Name = "viewUsers";
            this.Size = new System.Drawing.Size(873, 503);
            this.Load += new System.EventHandler(this.viewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstUsersItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView lstUsersItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colLibrarianID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddlename;
        private DevExpress.XtraGrid.Columns.GridColumn colLastname;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdited;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
    }
}
