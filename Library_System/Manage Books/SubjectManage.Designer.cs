namespace Library_System.Manage_Books
{
    partial class subjectManage
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
            this.lstSubject = new DevExpress.XtraGrid.GridControl();
            this.lstSubjectItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSubjectItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSubject
            // 
            this.lstSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSubject.Location = new System.Drawing.Point(0, 0);
            this.lstSubject.MainView = this.lstSubjectItem;
            this.lstSubject.Name = "lstSubject";
            this.lstSubject.Size = new System.Drawing.Size(517, 482);
            this.lstSubject.TabIndex = 0;
            this.lstSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstSubjectItem});
            // 
            // lstSubjectItem
            // 
            this.lstSubjectItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colSubjectID,
            this.colSubjectName,
            this.colIsEdited});
            this.lstSubjectItem.GridControl = this.lstSubject;
            this.lstSubjectItem.Name = "lstSubjectItem";
            this.lstSubjectItem.OptionsFind.AlwaysVisible = true;
            this.lstSubjectItem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.lstSubjectItem_RowCellStyle);
            this.lstSubjectItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstSubjectItem_CellValueChanged);
            this.lstSubjectItem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstSubjectItem_CellValueChanging);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            // 
            // colSubjectID
            // 
            this.colSubjectID.Caption = "Subject ID";
            this.colSubjectID.FieldName = "subjectID";
            this.colSubjectID.Name = "colSubjectID";
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "Subject Name";
            this.colSubjectName.FieldName = "subjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 0;
            // 
            // colIsEdited
            // 
            this.colIsEdited.Caption = "Is Edited";
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
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // subjectManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstSubject);
            this.Name = "subjectManage";
            this.Size = new System.Drawing.Size(517, 482);
            this.Load += new System.EventHandler(this.SubjectManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstSubjectItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView lstSubjectItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdited;
    }
}
