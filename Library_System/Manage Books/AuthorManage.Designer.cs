namespace Library_System.Manage_Books
{
    partial class authorManage
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.lstAuthor = new DevExpress.XtraGrid.GridControl();
            this.corporateView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorporation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            this.personView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdited2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnIsPersonView = new DevExpress.XtraEditors.CheckButton();
            this.colCorporation2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personView)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAuthor
            // 
            this.lstAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.corporateView;
            gridLevelNode1.RelationName = "Level1";
            this.lstAuthor.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.lstAuthor.Location = new System.Drawing.Point(0, 0);
            this.lstAuthor.MainView = this.personView;
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(761, 524);
            this.lstAuthor.TabIndex = 0;
            this.lstAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.corporateView,
            this.personView});
            // 
            // corporateView
            // 
            this.corporateView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colAuthorID,
            this.colFname,
            this.colMname,
            this.colLname,
            this.colCorporation,
            this.colIsEdited});
            this.corporateView.GridControl = this.lstAuthor;
            this.corporateView.Name = "corporateView";
            this.corporateView.OptionsFind.AlwaysVisible = true;
            this.corporateView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.personView_RowCellStyle);
            this.corporateView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.personView_CellValueChanged);
            this.corporateView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.personView_CellValueChanging);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Width = 104;
            // 
            // colAuthorID
            // 
            this.colAuthorID.Caption = "Author ID";
            this.colAuthorID.FieldName = "authorID";
            this.colAuthorID.Name = "colAuthorID";
            // 
            // colFname
            // 
            this.colFname.Caption = "Firstname";
            this.colFname.FieldName = "fname";
            this.colFname.Name = "colFname";
            // 
            // colMname
            // 
            this.colMname.Caption = "Middlename/Intial";
            this.colMname.FieldName = "mname";
            this.colMname.Name = "colMname";
            // 
            // colLname
            // 
            this.colLname.Caption = "Lastname";
            this.colLname.FieldName = "lname";
            this.colLname.Name = "colLname";
            // 
            // colCorporation
            // 
            this.colCorporation.Caption = "Corporate Name";
            this.colCorporation.FieldName = "corporation";
            this.colCorporation.Name = "colCorporation";
            this.colCorporation.Visible = true;
            this.colCorporation.VisibleIndex = 0;
            // 
            // colIsEdited
            // 
            this.colIsEdited.Caption = "Is Edited";
            this.colIsEdited.FieldName = "isEdited";
            this.colIsEdited.Name = "colIsEdited";
            // 
            // personView
            // 
            this.personView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected2,
            this.colAuthorID2,
            this.colFname2,
            this.colMname2,
            this.colLname2,
            this.colCorporation2,
            this.colIsEdited2});
            this.personView.GridControl = this.lstAuthor;
            this.personView.Name = "personView";
            this.personView.OptionsFind.AlwaysVisible = true;
            this.personView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.personView_RowCellStyle);
            this.personView.ShownEditor += new System.EventHandler(this.personView_ShownEditor);
            this.personView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.personView_CellValueChanged);
            this.personView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.personView_CellValueChanging);
            // 
            // colIsSelected2
            // 
            this.colIsSelected2.Caption = "Selected";
            this.colIsSelected2.FieldName = "isSelected";
            this.colIsSelected2.Name = "colIsSelected2";
            this.colIsSelected2.Width = 104;
            // 
            // colAuthorID2
            // 
            this.colAuthorID2.Caption = "Author ID";
            this.colAuthorID2.FieldName = "authorID";
            this.colAuthorID2.Name = "colAuthorID2";
            // 
            // colFname2
            // 
            this.colFname2.Caption = "Firstname";
            this.colFname2.FieldName = "fname";
            this.colFname2.Name = "colFname2";
            this.colFname2.Visible = true;
            this.colFname2.VisibleIndex = 0;
            // 
            // colMname2
            // 
            this.colMname2.Caption = "Middlename/Intial";
            this.colMname2.FieldName = "mname";
            this.colMname2.Name = "colMname2";
            this.colMname2.Visible = true;
            this.colMname2.VisibleIndex = 1;
            // 
            // colLname2
            // 
            this.colLname2.Caption = "Lastname";
            this.colLname2.FieldName = "lname";
            this.colLname2.Name = "colLname2";
            this.colLname2.Visible = true;
            this.colLname2.VisibleIndex = 2;
            // 
            // colIsEdited2
            // 
            this.colIsEdited2.Caption = "Is Edited";
            this.colIsEdited2.FieldName = "isEdited";
            this.colIsEdited2.Name = "colIsEdited2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(16, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // btnIsPersonView
            // 
            this.btnIsPersonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIsPersonView.Location = new System.Drawing.Point(595, 12);
            this.btnIsPersonView.Name = "btnIsPersonView";
            this.btnIsPersonView.Size = new System.Drawing.Size(151, 23);
            this.btnIsPersonView.TabIndex = 39;
            this.btnIsPersonView.Text = "View Corporate Authors";
            this.btnIsPersonView.CheckedChanged += new System.EventHandler(this.btnIsPersonView_CheckedChanged);
            // 
            // colCorporation2
            // 
            this.colCorporation2.Caption = "Corporate Name";
            this.colCorporation2.FieldName = "corporation";
            this.colCorporation2.Name = "colCorporation2";
            // 
            // authorManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIsPersonView);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstAuthor);
            this.Name = "authorManage";
            this.Size = new System.Drawing.Size(761, 524);
            this.Load += new System.EventHandler(this.AuthorManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corporateView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstAuthor;
        private DevExpress.XtraGrid.Views.Grid.GridView corporateView;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorID;
        private DevExpress.XtraGrid.Columns.GridColumn colFname;
        private DevExpress.XtraGrid.Columns.GridColumn colMname;
        private DevExpress.XtraGrid.Columns.GridColumn colLname;
        private DevExpress.XtraGrid.Columns.GridColumn colCorporation;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdited;
        private DevExpress.XtraGrid.Views.Grid.GridView personView;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected2;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorID2;
        private DevExpress.XtraGrid.Columns.GridColumn colFname2;
        private DevExpress.XtraGrid.Columns.GridColumn colMname2;
        private DevExpress.XtraGrid.Columns.GridColumn colLname2;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdited2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckButton btnIsPersonView;
        private DevExpress.XtraGrid.Columns.GridColumn colCorporation2;

    }
}
