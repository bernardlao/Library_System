namespace Library_System.Borrowers_Menu
{
    partial class RegisterBorrower
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.optOthers = new DevExpress.XtraEditors.CheckEdit();
            this.optTeacher = new DevExpress.XtraEditors.CheckEdit();
            this.optStudent = new DevExpress.XtraEditors.CheckEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBday = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBorrowerID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optOthers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorrowerID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControl1.Controls.Add(this.optOthers);
            this.groupControl1.Controls.Add(this.optTeacher);
            this.groupControl1.Controls.Add(this.optStudent);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.dtpBday);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtLname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtFname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBorrowerID);
            this.groupControl1.Location = new System.Drawing.Point(10, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(367, 463);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Your Information";
            // 
            // optOthers
            // 
            this.optOthers.Location = new System.Drawing.Point(276, 38);
            this.optOthers.Name = "optOthers";
            this.optOthers.Properties.Caption = "Others";
            this.optOthers.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.optOthers.Properties.RadioGroupIndex = 1;
            this.optOthers.Size = new System.Drawing.Size(62, 19);
            this.optOthers.TabIndex = 2;
            this.optOthers.TabStop = false;
            this.optOthers.CheckedChanged += new System.EventHandler(this.optStudent_CheckedChanged);
            // 
            // optTeacher
            // 
            this.optTeacher.Location = new System.Drawing.Point(195, 38);
            this.optTeacher.Name = "optTeacher";
            this.optTeacher.Properties.Caption = "Teacher";
            this.optTeacher.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.optTeacher.Properties.RadioGroupIndex = 1;
            this.optTeacher.Size = new System.Drawing.Size(75, 19);
            this.optTeacher.TabIndex = 1;
            this.optTeacher.TabStop = false;
            this.optTeacher.CheckedChanged += new System.EventHandler(this.optStudent_CheckedChanged);
            // 
            // optStudent
            // 
            this.optStudent.EditValue = true;
            this.optStudent.Location = new System.Drawing.Point(114, 38);
            this.optStudent.Name = "optStudent";
            this.optStudent.Properties.Caption = "Student";
            this.optStudent.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.optStudent.Properties.RadioGroupIndex = 1;
            this.optStudent.Size = new System.Drawing.Size(75, 19);
            this.optStudent.TabIndex = 0;
            this.optStudent.CheckedChanged += new System.EventHandler(this.optStudent_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(102, 251);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(233, 96);
            this.txtAddress.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 253);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Address :";
            // 
            // dtpBday
            // 
            this.dtpBday.EditValue = null;
            this.dtpBday.Location = new System.Drawing.Point(102, 215);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBday.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpBday.Size = new System.Drawing.Size(233, 20);
            this.dtpBday.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 218);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Birthdate :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Lastname :";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(102, 180);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(233, 20);
            this.txtLname.TabIndex = 10;
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Middlename :";
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(102, 145);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(233, 20);
            this.txtMname.TabIndex = 8;
            this.txtMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Firstname :";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(102, 110);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(233, 20);
            this.txtFname.TabIndex = 6;
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Your ID :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Borrower Type :";
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Location = new System.Drawing.Point(102, 75);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Properties.MaxLength = 12;
            this.txtBorrowerID.Size = new System.Drawing.Size(233, 20);
            this.txtBorrowerID.TabIndex = 3;
            this.txtBorrowerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBorrowerID_KeyPress);
            // 
            // RegisterBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupControl1);
            this.Name = "RegisterBorrower";
            this.Size = new System.Drawing.Size(392, 489);
            this.Load += new System.EventHandler(this.RegisterBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optOthers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBorrowerID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtBorrowerID;
        public DevExpress.XtraEditors.MemoEdit txtAddress;
        public DevExpress.XtraEditors.DateEdit dtpBday;
        public DevExpress.XtraEditors.TextEdit txtLname;
        public DevExpress.XtraEditors.TextEdit txtMname;
        public DevExpress.XtraEditors.TextEdit txtFname;
        public DevExpress.XtraEditors.CheckEdit optOthers;
        public DevExpress.XtraEditors.CheckEdit optTeacher;
        public DevExpress.XtraEditors.CheckEdit optStudent;

    }
}
