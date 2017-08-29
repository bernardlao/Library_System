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
            this.txtAuthorLname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorMname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtAuthorFname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddAuthor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthorItem)).BeginInit();
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
            this.lstBookAuthor.Location = new System.Drawing.Point(3, 53);
            this.lstBookAuthor.MainView = this.lstBookAuthorItem;
            this.lstBookAuthor.Name = "lstBookAuthor";
            this.lstBookAuthor.Size = new System.Drawing.Size(790, 475);
            this.lstBookAuthor.TabIndex = 4;
            this.lstBookAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBookAuthorItem});
            // 
            // lstBookAuthorItem
            // 
            this.lstBookAuthorItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuthorID,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName});
            this.lstBookAuthorItem.GridControl = this.lstBookAuthor;
            this.lstBookAuthorItem.Name = "lstBookAuthorItem";
            this.lstBookAuthorItem.OptionsBehavior.Editable = false;
            this.lstBookAuthorItem.OptionsFind.AlwaysVisible = true;
            this.lstBookAuthorItem.OptionsSelection.MultiSelect = true;
            this.lstBookAuthorItem.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // colAuthorID
            // 
            this.colAuthorID.Caption = "Author ID";
            this.colAuthorID.FieldName = "authorID";
            this.colAuthorID.Name = "colAuthorID";
            this.colAuthorID.Visible = true;
            this.colAuthorID.VisibleIndex = 4;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "First Name";
            this.colFirstName.FieldName = "fname";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            this.colFirstName.Width = 191;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Middle Name/Initial";
            this.colMiddleName.FieldName = "mname";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 1;
            this.colMiddleName.Width = 138;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Last Name";
            this.colLastName.FieldName = "lname";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            this.colLastName.Width = 200;
            // 
            // txtAuthorLname
            // 
            this.txtAuthorLname.Location = new System.Drawing.Point(574, 17);
            this.txtAuthorLname.Name = "txtAuthorLname";
            this.txtAuthorLname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorLname.TabIndex = 3;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(511, 20);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(57, 13);
            this.labelControl14.TabIndex = 34;
            this.labelControl14.Text = "Last Name :";
            // 
            // txtAuthorMname
            // 
            this.txtAuthorMname.Location = new System.Drawing.Point(345, 17);
            this.txtAuthorMname.Name = "txtAuthorMname";
            this.txtAuthorMname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorMname.TabIndex = 2;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(242, 20);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(97, 13);
            this.labelControl15.TabIndex = 32;
            this.labelControl15.Text = "Middle Name/Initial :";
            // 
            // txtAuthorFname
            // 
            this.txtAuthorFname.Location = new System.Drawing.Point(76, 17);
            this.txtAuthorFname.Name = "txtAuthorFname";
            this.txtAuthorFname.Size = new System.Drawing.Size(160, 20);
            this.txtAuthorFname.TabIndex = 1;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(12, 20);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(58, 13);
            this.labelControl16.TabIndex = 30;
            this.labelControl16.Text = "First Name :";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(748, 15);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(38, 23);
            this.btnAddAuthor.TabIndex = 35;
            this.btnAddAuthor.Text = "+";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // addBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.txtAuthorLname);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtAuthorMname);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.txtAuthorFname);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.lstBookAuthor);
            this.Name = "addBookAuthor";
            this.Size = new System.Drawing.Size(796, 531);
            this.Load += new System.EventHandler(this.addBookAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBookAuthorItem)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtAuthorLname;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtAuthorMname;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtAuthorFname;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.SimpleButton btnAddAuthor;
        public DevExpress.XtraGrid.GridControl lstBookAuthor;

    }
}
