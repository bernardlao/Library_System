namespace Library_System.Borrowers_Menu
{
    partial class Borrowers
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
            this.lstBorrower = new DevExpress.XtraGrid.GridControl();
            this.lstBorrowerItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBorrowerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblForEdit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowerItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBorrower
            // 
            this.lstBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrower.Location = new System.Drawing.Point(0, 0);
            this.lstBorrower.MainView = this.lstBorrowerItem;
            this.lstBorrower.Name = "lstBorrower";
            this.lstBorrower.Size = new System.Drawing.Size(1067, 503);
            this.lstBorrower.TabIndex = 0;
            this.lstBorrower.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBorrowerItem});
            // 
            // lstBorrowerItem
            // 
            this.lstBorrowerItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colBorrowerID,
            this.colFirstname,
            this.colMiddlename,
            this.colLastname,
            this.colBirthdate,
            this.colAddress});
            this.lstBorrowerItem.GridControl = this.lstBorrower;
            this.lstBorrowerItem.Name = "lstBorrowerItem";
            this.lstBorrowerItem.OptionsBehavior.Editable = false;
            this.lstBorrowerItem.OptionsFind.AlwaysVisible = true;
            this.lstBorrowerItem.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.lstBorrowerItem_RowCellClick);
            this.lstBorrowerItem.DoubleClick += new System.EventHandler(this.lstBorrowerItem_DoubleClick);
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
            // colBorrowerID
            // 
            this.colBorrowerID.Caption = "ID";
            this.colBorrowerID.FieldName = "borrowerID";
            this.colBorrowerID.Name = "colBorrowerID";
            this.colBorrowerID.Visible = true;
            this.colBorrowerID.VisibleIndex = 1;
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
            this.colMiddlename.Caption = "Middlename";
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
            // colBirthdate
            // 
            this.colBirthdate.Caption = "Birthdate";
            this.colBirthdate.FieldName = "bdate";
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.Visible = true;
            this.colBirthdate.VisibleIndex = 5;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
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
            // lblForEdit
            // 
            this.lblForEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForEdit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblForEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForEdit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblForEdit.Location = new System.Drawing.Point(901, 48);
            this.lblForEdit.Name = "lblForEdit";
            this.lblForEdit.Size = new System.Drawing.Size(163, 11);
            this.lblForEdit.TabIndex = 42;
            this.lblForEdit.Text = "Edit Note : Double click an Item to Edit";
            this.lblForEdit.Visible = false;
            // 
            // Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblForEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstBorrower);
            this.Name = "Borrowers";
            this.Size = new System.Drawing.Size(1067, 503);
            this.Load += new System.EventHandler(this.Borrowers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowerItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstBorrower;
        private DevExpress.XtraGrid.Views.Grid.GridView lstBorrowerItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colBorrowerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstname;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddlename;
        private DevExpress.XtraGrid.Columns.GridColumn colLastname;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthdate;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblForEdit;
    }
}
