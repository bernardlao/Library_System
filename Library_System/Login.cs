using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassCollection;

namespace Library_System
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        string server, port, database = "DATABASE=db_library;", uid, password;

        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        private ConnectionStringSolution cs = new ConnectionStringSolution();
        public bool isValid = false;
        public bool isConnected = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            frmMain.userLoggedIn = null;
            if (db.OpenConnection() == null)
            {
                this.Size = new Size(555, this.Size.Height);
                this.Location = new Point(this.Location.X - 127, this.Location.Y);
                btnLogin.Enabled = false;
                lnkLoginGuest.Enabled = false;
                btnConnection.Enabled = false;
                isConnected = false;
                EnableConnectionControls(true);
                //Edited.
            }
            else
            {
                this.Size = new Size(300, this.Size.Height);
                isConnected = true;
                DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE username ='admin'");
                if (dt != null)
                {
                    if (dt.Rows.Count == 0)
                    {
                        string salt = hm.GenerateSalt(("admin").Length);
                        string pass = hm.GenerateSHA256("admin" + salt);
                        db.InsertQuery("INSERT INTO tbluser (username, password, salt, librarianID, fname, mname, lname) VALUES('admin','" +
                            pass + "','" + salt + "',null,'admin',null,'admin');");
                    }
                }
                EnableConnectionControls(false);
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !(isValid && isConnected))
            {
                Environment.Exit(1);
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SuperUserPassword sup = new SuperUserPassword();
            sup.ShowDialog();
            if (SuperUserPassword.allowEntry)
            {
                this.Size = new Size(555, this.Size.Height);
                this.Location = new Point(this.Location.X - 127, this.Location.Y);
                btnConnection.Enabled = false;
                EnableConnectionControls(!btnApplyConnection.Enabled);
            }
        }

        private void btnCloseConnectionSet_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, this.Size.Height);
            this.Location = new Point(this.Location.X + 127, this.Location.Y);
            btnConnection.Enabled = true;
            EnableConnectionControls(!btnApplyConnection.Enabled);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            server = "SERVER=" + txtServer.Text + ";";
            port = "PORT=" + txtPort.Text + ";";
            uid = "UID=" + txtUID.Text + ";";
            password = "PASSWORD=" + txtPwd.Text + ";";
            if (db.OpenConnection(server + port + database + uid + password) == null)
            {
                XtraMessageBox.Show("Connection Invalid!", "Connnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Connection Valid!", "Connnection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApplyConnection_Click(object sender, EventArgs e)
        {
            server = "SERVER=" + txtServer.Text + ";";
            port = "PORT=" + txtPort.Text + ";";
            uid = "UID=" + txtUID.Text + ";";
            password = "PASSWORD=" + txtPwd.Text + ";";
            if (db.OpenConnection(server + port + database + uid + password) != null)
            {
                if (DialogResult.Yes == XtraMessageBox.Show("Connection Valid! Do you want to use the created connection?", "Connection Success",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    cs.CreateRegistryKey("ConnectionString", server + port + database + uid + password);
                    isConnected = true;
                    btnLogin.Enabled = true;
                    lnkLoginGuest.Enabled = true;
                }
            }
            else
                XtraMessageBox.Show("Connection Invalid!", "Connnection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsAccountValid())
            {
                isValid = true;
                frmMain.triggerDesigner = true;
                this.Close();
            }
           
        }
        public bool IsAccountValid()
        {
            if (txtUsername.Text.Equals("Username") || txtPassword.Text.Equals("Password") || txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                XtraMessageBox.Show("The username and password must not be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE username='" + username + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string salt = r["salt"].ToString();
                    string saltedPassword = hm.GenerateSHA256(password + salt);
                    if (salt.Equals(""))
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show("You don't have an existing password.\n Would you like to use the current typed password as your password?\n" +
                            "Note : You need to contact the administrator when you want to reset your password.", "Account Validation", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
                        {
                            salt = hm.GenerateSalt(txtPassword.Text.Length);
                            saltedPassword = hm.GenerateSHA256(txtPassword.Text + salt);
                            db.InsertQuery("UPDATE tbluser SET password='" + saltedPassword + "', salt='" + salt + "' WHERE userID=" + r["userID"].ToString());
                            frmMain.userLoggedIn = r["userID"].ToString();
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                    {
                        if (r["password"].ToString().Equals(saltedPassword))
                        {
                            frmMain.userLoggedIn = r["userID"].ToString();
                            return true;
                        }
                    }
                }
            }
            XtraMessageBox.Show("There is no such account existing.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.AlphaNumericOnly(ref sender, ref e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (IsAccountValid())
                {
                    frmMain.triggerDesigner = true;
                    isValid = true;
                    this.Close();
                }
            }
        }

        private void lnkLoginGuest_Click(object sender, EventArgs e)
        {
            isValid = true;
            frmMain.userLoggedIn = "Guest";
            frmMain.triggerDesigner = true;
            this.Close();
        }
        private void EnableConnectionControls(bool enable)
        {
            txtPort.Enabled = enable;
            txtPwd.Enabled = enable;
            txtServer.Enabled = enable;
            txtUID.Enabled = enable;
            btnApplyConnection.Enabled = enable;
            btnTestConnection.Enabled = enable;
            btnCloseConnectionSet.Enabled = enable;
            picLogo.Enabled = enable;

            btnLogin.Enabled = !enable;
            lnkLoginGuest.Enabled = !enable;
            txtPassword.Enabled = !enable;
            txtUsername.Enabled = !enable;
        }
    }
}