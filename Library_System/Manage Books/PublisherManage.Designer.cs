namespace Library_System.Manage_Books
{
    partial class publisherManage
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
            this.lstPublisher = new DevExpress.XtraGrid.GridControl();
            this.lstPublisherItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublisherID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublisherName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEdited = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lstPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPublisherItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPublisher
            // 
            this.lstPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPublisher.Location = new System.Drawing.Point(0, 0);
            this.lstPublisher.MainView = this.lstPublisherItem;
            this.lstPublisher.Name = "lstPublisher";
            this.lstPublisher.Size = new System.Drawing.Size(598, 515);
            this.lstPublisher.TabIndex = 0;
            this.lstPublisher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lstPublisherItem});
            // 
            // lstPublisherItem
            // 
            this.lstPublisherItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colPublisherID,
            this.colPublisherName,
            this.colAddress,
            this.colIsEdited});
            this.lstPublisherItem.GridControl = this.lstPublisher;
            this.lstPublisherItem.Name = "lstPublisherItem";
            this.lstPublisherItem.OptionsFind.AlwaysVisible = true;
            this.lstPublisherItem.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.lstPublisherItem_RowCellStyle);
            this.lstPublisherItem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstPublisherItem_CellValueChanged);
            this.lstPublisherItem.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.lstPublisherItem_CellValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 11);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Note : When searching more than one word please enter \" at both ends for precise " +
    "searching";
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.FieldName = "isSelected";
            this.colIsSelected.Name = "colIsSelected";
            // 
            // colPublisherID
            // 
            this.colPublisherID.Caption = "Publisher ID";
            this.colPublisherID.FieldName = "publisherID";
            this.colPublisherID.Name = "colPublisherID";
            // 
            // colPublisherName
            // 
            this.colPublisherName.Caption = "Publisher Name";
            this.colPublisherName.FieldName = "publisherName";
            this.colPublisherName.Name = "colPublisherName";
            this.colPublisherName.Visible = true;
            this.colPublisherName.VisibleIndex = 0;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            // 
            // colIsEdited
            // 
            this.colIsEdited.Caption = "Is Edited";
            this.colIsEdited.FieldName = "isEdited";
            this.colIsEdited.Name = "colIsEdited";
            // 
            // publisherManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstPublisher);
            this.Name = "publisherManage";
            this.Size = new System.Drawing.Size(598, 515);
            this.Load += new System.EventHandler(this.publisherManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPublisherItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl lstPublisher;
        private DevExpress.XtraGrid.Views.Grid.GridView lstPublisherItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisherID;
        private DevExpress.XtraGrid.Columns.GridColumn colPublisherName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEdited;
    }
}
