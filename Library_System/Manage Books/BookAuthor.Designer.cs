namespace Library_System
{
    partial class addBookAuthor
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
            this.lstBookAuthor = new DevExpress.XtraGrid.GridControl();
            this.lstBookAuthorItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAuthorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            this.txtAuthorLname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorMname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorFname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthorItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorLname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorMname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorFname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBookAuthor
            // 
            this.lstBookAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBookAuthor.Location = new System.Drawing.Point(3, 85);
            this.lstBookAuthor.MainView = this.lstBookAuthorItem;
            this.lstBookAuthor.Name = "lstBookAuthor";
            this.lstBookAuthor.Size = new System.Drawing.Size(806, 600);
            this.lstBookAuthor.TabIndex = 5;
            this.lstBookAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBookAuthorItem});
            // 
            // lstBookAuthorItem
            // 
            this.lstBookAuthorItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuthorID,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colIsSelected});
            this.lstBookAuthorItem.GridControl = this.lstBookAuthor;
            this.lstBookAuthorItem.Name = "lstBookAuthorItem";
            this.lstBookAuthorItem.OptionsFind.AlwaysVisible = true;
            this.lstBookAuthorItem.OptionsView.EnableAppearanceEvenRow = true;
            this.lstBookAuthorItem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstBookAuthorItem_CellValueChanging);
            // 
            // colAuthorID
            // 
            this.colAuthorID.Caption = "Author ID";
            this.colAuthorID.FieldName = "authorID";
            this.colAuthorID.Name = "colAuthorID";
            this.colAuthorID.OptionsColumn.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "fname";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.OptionsColumn.ReadOnly = true;
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 191;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Middle Name/Initial";
            this.colMiddleName.FieldName = "mname";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.OptionsColumn.ReadOnly = true;
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 2;
            this.colMiddleName.Width = 138;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "lname";
            this.colLastName.Name = "colLastName";
            this.colLastName.OptionsColumn.ReadOnly = true;
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            this.colLastName.Width = 200;
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Select";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(18, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAddAuthor);
            this.groupControl1.Controls.Add(this.txtAuthorLname);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.txtAuthorMname);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.txtAuthorFname);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(805, 76);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "Author Information";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(754, 35);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(38, 23);
            this.btnAddAuthor.TabIndex = 38;
            this.btnAddAuthor.Text = "+";
            // 
            // txtAuthorLname
            // 
            this.txtAuthorLname.Location = new System.Drawing.Point(580, 37);
            this.txtAuthorLname.Name = "txtAuthorLname";
            this.txtAuthorLname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorLname.TabIndex = 37;
            this.txtAuthorLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorLname_KeyPress);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(517, 40);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(57, 13);
            this.labelControl14.TabIndex = 41;
            this.labelControl14.Text = "Last Name :";
            // 
            // txtAuthorMname
            // 
            this.txtAuthorMname.Location = new System.Drawing.Point(351, 37);
            this.txtAuthorMname.Name = "txtAuthorMname";
            this.txtAuthorMname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorMname.TabIndex = 36;
            this.txtAuthorMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorLname_KeyPress);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(248, 40);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(97, 13);
            this.labelControl15.TabIndex = 40;
            this.labelControl15.Text = "Middle Name/Initial :";
            // 
            // txtAuthorFname
            // 
            this.txtAuthorFname.Location = new System.Drawing.Point(82, 37);
            this.txtAuthorFname.Name = "txtAuthorFname";
            this.txtAuthorFname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorFname.TabIndex = 35;
            this.txtAuthorFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthorLname_KeyPress);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(18, 40);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(58, 13);
            this.labelControl16.TabIndex = 39;
            this.labelControl16.Text = "First Name :";
            // 
            // addBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstBookAuthor);
            this.Name = "addBookAuthor";
            this.Size = new System.Drawing.Size(812, 689);
            this.Load += new System.EventHandler(this.addBookAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthorItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorLname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorMname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorFname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView lstBookAuthorItem;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorID;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        public DevExpress.XtraGrid.GridControl lstBookAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        private DevExpress.XtraEditors.TextEdit txtAuthorLname;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtAuthorMname;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtAuthorFname;
        private DevExpress.XtraEditors.LabelControl labelControl16;

    }
}
