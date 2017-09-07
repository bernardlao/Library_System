namespace Library_System
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lnkLoginGuest = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnection = new DevExpress.XtraEditors.SimpleButton();
            this.lnkRegister = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.txtUID = new DevExpress.XtraEditors.TextEdit();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.btnTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnCloseConnectionSet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(40, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.NullText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(209, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.NullText = "Password";
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lnkLoginGuest
            // 
            this.lnkLoginGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLoginGuest.Location = new System.Drawing.Point(179, 139);
            this.lnkLoginGuest.Name = "lnkLoginGuest";
            this.lnkLoginGuest.Size = new System.Drawing.Size(70, 13);
            this.lnkLoginGuest.TabIndex = 7;
            this.lnkLoginGuest.Text = "Login as Guest";
            this.lnkLoginGuest.Click += new System.EventHandler(this.lnkLoginGuest_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(40, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(209, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.Location = new System.Drawing.Point(125, 171);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(39, 36);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.ToolTip = "Manage Database Connection";
            this.btnConnection.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.btnConnection.ToolTipTitle = "For Administrator Only";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lnkRegister
            // 
            this.lnkRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRegister.Location = new System.Drawing.Point(40, 139);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(64, 13);
            this.lnkRegister.TabIndex = 6;
            this.lnkRegister.Text = "Register Now";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(139, 141);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "or";
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.Black;
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.LineThickness = 1;
            this.separatorControl1.Location = new System.Drawing.Point(280, -1);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(26, 231);
            this.separatorControl1.TabIndex = 10;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(312, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogo.Size = new System.Drawing.Size(131, 96);
            this.picLogo.TabIndex = 11;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(312, 114);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.NullText = "Server";
            this.txtServer.Size = new System.Drawing.Size(209, 20);
            this.txtServer.TabIndex = 12;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(312, 140);
            this.txtPort.Name = "txtPort";
            this.txtPort.Properties.NullText = "Port";
            this.txtPort.Size = new System.Drawing.Size(209, 20);
            this.txtPort.TabIndex = 13;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(312, 166);
            this.txtUID.Name = "txtUID";
            this.txtUID.Properties.NullText = "Username";
            this.txtUID.Size = new System.Drawing.Size(209, 20);
            this.txtUID.TabIndex = 14;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(312, 192);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Properties.NullText = "Password";
            this.txtPwd.Size = new System.Drawing.Size(209, 20);
            this.txtPwd.TabIndex = 15;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(445, 56);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(76, 23);
            this.btnTestConnection.TabIndex = 16;
            this.btnTestConnection.Text = "Test";
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnApplyConnection
            // 
            this.btnApplyConnection.Location = new System.Drawing.Point(445, 85);
            this.btnApplyConnection.Name = "btnApplyConnection";
            this.btnApplyConnection.Size = new System.Drawing.Size(76, 23);
            this.btnApplyConnection.TabIndex = 17;
            this.btnApplyConnection.Text = "Apply";
            this.btnApplyConnection.Click += new System.EventHandler(this.btnApplyConnection_Click);
            // 
            // btnCloseConnectionSet
            // 
            this.btnCloseConnectionSet.Location = new System.Drawing.Point(445, 12);
            this.btnCloseConnectionSet.Name = "btnCloseConnectionSet";
            this.btnCloseConnectionSet.Size = new System.Drawing.Size(76, 23);
            this.btnCloseConnectionSet.TabIndex = 18;
            this.btnCloseConnectionSet.Text = "<< Back";
            this.btnCloseConnectionSet.Click += new System.EventHandler(this.btnCloseConnectionSet_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.btnCloseConnectionSet);
            this.Controls.Add(this.btnApplyConnection);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkLoginGuest);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkLoginGuest;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnConnection;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkRegister;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private DevExpress.XtraEditors.TextEdit txtUID;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.SimpleButton btnTestConnection;
        private DevExpress.XtraEditors.SimpleButton btnApplyConnection;
        private DevExpress.XtraEditors.SimpleButton btnCloseConnectionSet;
    }
}