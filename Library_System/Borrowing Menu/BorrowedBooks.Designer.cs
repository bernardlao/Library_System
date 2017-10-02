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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBorrowed
            // 
            this.lstBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBorrowed.Location = new System.Drawing.Point(0, 0);
            this.lstBorrowed.MainView = this.lstBorrowedItem;
            this.lstBorrowed.Name = "lstBorrowed";
            this.lstBorrowed.Size = new System.Drawing.Size(1161, 480);
            this.lstBorrowed.TabIndex = 0;
            this.lstBorrowed.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstBorrowedItem});
            // 
            // lstBorrowedItem
            // 
            this.lstBorrowedItem.GridControl = this.lstBorrowed;
            this.lstBorrowedItem.Name = "lstBorrowedItem";
            this.lstBorrowedItem.OptionsBehavior.Editable = false;
            this.lstBorrowedItem.OptionsFind.AlwaysVisible = true;
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
            // BorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstBorrowed);
            this.Name = "BorrowedBooks";
            this.Size = new System.Drawing.Size(1161, 480);
            this.Load += new System.EventHandler(this.BorrowedBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBorrowedItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstBorrowed;
        private DevExpress.XtraGrid.Views.Grid.GridView lstBorrowedItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
