namespace Library_System.Borrowers_Menu
{
    partial class BorrowMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowMenu));
            this.gpbBookInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtAuthors = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gpbBorrowerInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblFullname = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtBorrowerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gpbBorrowInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnBorrow = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tmSetter = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gpbBookInfo)).BeginInit();
            this.gpbBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbBorrowerInfo)).BeginInit();
            this.gpbBorrowerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorrowerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbBorrowInfo)).BeginInit();
            this.gpbBorrowInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBookInfo
            // 
            this.gpbBookInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbBookInfo.Controls.Add(this.txtAuthors);
            this.gpbBookInfo.Controls.Add(this.labelControl2);
            this.gpbBookInfo.Controls.Add(this.txtTitle);
            this.gpbBookInfo.Controls.Add(this.labelControl1);
            this.gpbBookInfo.Location = new System.Drawing.Point(3, 3);
            this.gpbBookInfo.Name = "gpbBookInfo";
            this.gpbBookInfo.Size = new System.Drawing.Size(361, 173);
            this.gpbBookInfo.TabIndex = 0;
            this.gpbBookInfo.Text = "Book Information";
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(86, 96);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Properties.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(241, 41);
            this.txtAuthors.TabIndex = 3;
            this.txtAuthors.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Author(s) : ";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(241, 41);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Title : ";
            // 
            // gpbBorrowerInfo
            // 
            this.gpbBorrowerInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbBorrowerInfo.Controls.Add(this.lblFullname);
            this.gpbBorrowerInfo.Controls.Add(this.labelControl5);
            this.gpbBorrowerInfo.Controls.Add(this.labelControl4);
            this.gpbBorrowerInfo.Controls.Add(this.txtBorrowerID);
            this.gpbBorrowerInfo.Controls.Add(this.labelControl3);
            this.gpbBorrowerInfo.Location = new System.Drawing.Point(3, 182);
            this.gpbBorrowerInfo.Name = "gpbBorrowerInfo";
            this.gpbBorrowerInfo.Size = new System.Drawing.Size(361, 141);
            this.gpbBorrowerInfo.TabIndex = 1;
            this.gpbBorrowerInfo.Text = "Your Information";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblFullname.Location = new System.Drawing.Point(86, 89);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(241, 0);
            this.lblFullname.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Fullname :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(197, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 11);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Hit Enter to check your account";
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(86, 37);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(241, 20);
            this.txtBorrowerID.TabIndex = 1;
            this.txtBorrowerID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBorrowerID_KeyDown);
            this.txtBorrowerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrowerID_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "ID :";
            // 
            // gpbBorrowInfo
            // 
            this.gpbBorrowInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbBorrowInfo.Controls.Add(this.btnBorrow);
            this.gpbBorrowInfo.Controls.Add(this.txtQuantity);
            this.gpbBorrowInfo.Controls.Add(this.labelControl6);
            this.gpbBorrowInfo.Location = new System.Drawing.Point(3, 329);
            this.gpbBorrowInfo.Name = "gpbBorrowInfo";
            this.gpbBorrowInfo.Size = new System.Drawing.Size(361, 137);
            this.gpbBorrowInfo.TabIndex = 2;
            this.gpbBorrowInfo.Text = "Borrow Information";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.Image")));
            this.btnBorrow.Location = new System.Drawing.Point(115, 77);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(134, 39);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow this Book";
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = "1";
            this.txtQuantity.Location = new System.Drawing.Point(86, 36);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.MaxLength = 2;
            this.txtQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuantity.Size = new System.Drawing.Size(241, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit2_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Quantity :";
            // 
            // tmSetter
            // 
            this.tmSetter.Enabled = true;
            this.tmSetter.Tick += new System.EventHandler(this.tmSetter_Tick);
            // 
            // BorrowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbBorrowInfo);
            this.Controls.Add(this.gpbBorrowerInfo);
            this.Controls.Add(this.gpbBookInfo);
            this.Name = "BorrowMenu";
            this.Size = new System.Drawing.Size(370, 471);
            this.Load += new System.EventHandler(this.BorrowMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gpbBookInfo)).EndInit();
            this.gpbBookInfo.ResumeLayout(false);
            this.gpbBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbBorrowerInfo)).EndInit();
            this.gpbBorrowerInfo.ResumeLayout(false);
            this.gpbBorrowerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorrowerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpbBorrowInfo)).EndInit();
            this.gpbBorrowInfo.ResumeLayout(false);
            this.gpbBorrowInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpbBookInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtAuthors;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtTitle;
        private DevExpress.XtraEditors.GroupControl gpbBorrowerInfo;
        private DevExpress.XtraEditors.TextEdit txtBorrowerID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblFullname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl gpbBorrowInfo;
        private DevExpress.XtraEditors.SimpleButton btnBorrow;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Timer tmSetter;
    }
}
