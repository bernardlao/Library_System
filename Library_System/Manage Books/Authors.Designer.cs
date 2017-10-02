namespace Library_System.Manage_Books
{
    partial class Authors
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
            this.lstAuthors = new DevExpress.XtraGrid.GridControl();
            this.lstAuthorsItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAuthorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthorsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAuthors
            // 
            this.lstAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAuthors.Location = new System.Drawing.Point(0, 0);
            this.lstAuthors.MainView = this.lstAuthorsItem;
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(352, 491);
            this.lstAuthors.TabIndex = 0;
            this.lstAuthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstAuthorsItem});
            // 
            // lstAuthorsItem
            // 
            this.lstAuthorsItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuthorID,
            this.colAuthor});
            this.lstAuthorsItem.GridControl = this.lstAuthors;
            this.lstAuthorsItem.Name = "lstAuthorsItem";
            this.lstAuthorsItem.OptionsBehavior.Editable = false;
            this.lstAuthorsItem.OptionsCustomization.AllowColumnMoving = false;
            this.lstAuthorsItem.OptionsCustomization.AllowColumnResizing = false;
            this.lstAuthorsItem.OptionsCustomization.AllowFilter = false;
            this.lstAuthorsItem.OptionsCustomization.AllowGroup = false;
            this.lstAuthorsItem.OptionsCustomization.AllowQuickHideColumns = false;
            // 
            // colAuthorID
            // 
            this.colAuthorID.Caption = "AuthorID";
            this.colAuthorID.FieldName = "authorID";
            this.colAuthorID.Name = "colAuthorID";
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Author(s)";
            this.colAuthor.FieldName = "authors";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 0;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lstAuthors);
            this.Name = "Authors";
            this.Size = new System.Drawing.Size(352, 491);
            this.Load += new System.EventHandler(this.Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthorsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstAuthors;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorID;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        public DevExpress.XtraGrid.Views.Grid.GridView lstAuthorsItem;
    }
}
