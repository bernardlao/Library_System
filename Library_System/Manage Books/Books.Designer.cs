namespace Library_System.Manage_Books
{
    partial class Books
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
            this.lstBooks = new DevExpress.XtraGrid.GridControl();
            this.lstBooksItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCallNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearOfPublication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublisher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lblForEdit = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBooksItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBooks.Location = new System.Drawing.Point(0, 0);
            this.lstBooks.MainView = this.lstBooksItem;
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(1094, 524);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBooksItem});
            // 
            // lstBooksItem
            // 
            this.lstBooksItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colBookID,
            this.colCallNumber,
            this.colTitle,
            this.colYearOfPublication,
            this.colPages,
            this.colVolume,
            this.colQuantity,
            this.colISBN,
            this.colPublisher,
            this.colSubject});
            this.lstBooksItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.lstBooksItem.GridControl = this.lstBooks;
            this.lstBooksItem.Name = "lstBooksItem";
            this.lstBooksItem.OptionsFind.AlwaysVisible = true;
            this.lstBooksItem.Click += new System.EventHandler(this.lstBooksItem_Click);
            this.lstBooksItem.DoubleClick += new System.EventHandler(this.lstBooksItem_DoubleClick);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            this.colIsSelected.Width = 51;
            // 
            // colBookID
            // 
            this.colBookID.Caption = "Book ID";
            this.colBookID.FieldName = "bookID";
            this.colBookID.Name = "colBookID";
            this.colBookID.Width = 101;
            // 
            // colCallNumber
            // 
            this.colCallNumber.Caption = "Call Number";
            this.colCallNumber.FieldName = "callNumber";
            this.colCallNumber.Name = "colCallNumber";
            this.colCallNumber.OptionsColumn.ReadOnly = true;
            this.colCallNumber.Visible = true;
            this.colCallNumber.VisibleIndex = 1;
            this.colCallNumber.Width = 101;
            // 
            // colTitle
            // 
            this.colTitle.Caption = "Title";
            this.colTitle.FieldName = "title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.ReadOnly = true;
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            this.colTitle.Width = 101;
            // 
            // colYearOfPublication
            // 
            this.colYearOfPublication.Caption = "Year of Publication";
            this.colYearOfPublication.FieldName = "yearOfPublication";
            this.colYearOfPublication.Name = "colYearOfPublication";
            this.colYearOfPublication.OptionsColumn.ReadOnly = true;
            this.colYearOfPublication.Visible = true;
            this.colYearOfPublication.VisibleIndex = 3;
            this.colYearOfPublication.Width = 101;
            // 
            // colPages
            // 
            this.colPages.Caption = "Pages";
            this.colPages.FieldName = "pages";
            this.colPages.Name = "colPages";
            this.colPages.OptionsColumn.ReadOnly = true;
            this.colPages.Visible = true;
            this.colPages.VisibleIndex = 4;
            this.colPages.Width = 101;
            // 
            // colVolume
            // 
            this.colVolume.Caption = "Volume";
            this.colVolume.FieldName = "volume";
            this.colVolume.Name = "colVolume";
            this.colVolume.OptionsColumn.ReadOnly = true;
            this.colVolume.Visible = true;
            this.colVolume.VisibleIndex = 5;
            this.colVolume.Width = 101;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            this.colQuantity.Width = 101;
            // 
            // colISBN
            // 
            this.colISBN.Caption = "ISBN";
            this.colISBN.FieldName = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.OptionsColumn.ReadOnly = true;
            this.colISBN.Visible = true;
            this.colISBN.VisibleIndex = 7;
            this.colISBN.Width = 101;
            // 
            // colPublisher
            // 
            this.colPublisher.Caption = "Publisher";
            this.colPublisher.FieldName = "publisherName";
            this.colPublisher.Name = "colPublisher";
            this.colPublisher.OptionsColumn.ReadOnly = true;
            this.colPublisher.Visible = true;
            this.colPublisher.VisibleIndex = 8;
            this.colPublisher.Width = 101;
            // 
            // colSubject
            // 
            this.colSubject.Caption = "Subject";
            this.colSubject.FieldName = "subjectName";
            this.colSubject.Name = "colSubject";
            this.colSubject.OptionsColumn.ReadOnly = true;
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 9;
            this.colSubject.Width = 116;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtSearch);
            this.groupControl1.Location = new System.Drawing.Point(509, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(580, 42);
            this.groupControl1.TabIndex = 40;
            this.groupControl1.Text = "Search by Author";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(5, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(570, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblForEdit
            // 
            this.lblForEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblForEdit.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblForEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForEdit.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblForEdit.Location = new System.Drawing.Point(926, 49);
            this.lblForEdit.Name = "lblForEdit";
            this.lblForEdit.Size = new System.Drawing.Size(163, 11);
            this.lblForEdit.TabIndex = 41;
            this.lblForEdit.Text = "Edit Note : Double click an Item to Edit";
            this.lblForEdit.Visible = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblForEdit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstBooks);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(1094, 524);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBooksItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstBooks;
        private DevExpress.XtraGrid.Views.Grid.GridView lstBooksItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colBookID;
        private DevExpress.XtraGrid.Columns.GridColumn colCallNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colYearOfPublication;
        private DevExpress.XtraGrid.Columns.GridColumn colPages;
        private DevExpress.XtraGrid.Columns.GridColumn colVolume;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisher;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl lblForEdit;
    }
}
