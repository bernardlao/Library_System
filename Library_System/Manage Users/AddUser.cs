using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MyClassCollection;

namespace Library_System.Manage_Users
{
    public partial class addUser : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();

        public addUser()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.AlphaNumericOnly(ref sender, ref e);
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }

        public void SaveUser()
        {
            if(IsValidToSave())
            {
                string generatedSalt = hm.GenerateSalt(txtPassword.Text.Length);
                string passwordToSave = hm.GenerateSHA256(txtPassword.Text + generatedSalt);
                db.InsertQuery("INSERT INTO tbluser(username, password, salt, librarianID, fname, mname, lname) VALUES('" +
                    txtUsername.Text + "','" + passwordToSave + "','" + generatedSalt + "','" + txtLibrarianID.Text.Replace("'","''") + "','" +
                    txtFirstname.Text + "'," + (txtMiddlename.Text.Length == 0 ? "NULL" : "'" + txtMiddlename.Text + "'") + ",'" +
                    txtLastname.Text + "');");
                hm.ClearTextEdit(this);
            }
        }
        private bool IsValidToSave()
        {
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtLibrarianID.Text.Equals("") ||
                txtFirstname.Text.Equals("") || txtLastname.Text.Equals(""))
            {
                XtraMessageBox.Show("You must fill up all the informations indicated.\nMiddlename(Optional)", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUsername.Text.Equals("admin", StringComparison.CurrentCultureIgnoreCase))
            {
                XtraMessageBox.Show("The word ADMIN cannot be used as username!", "Username Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataTable dt = db.SelectTable("SELECT userID FROM tbluser WHERE username ='" + txtUsername.Text + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show("User already exist!", "Account Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (!txtPassword.Text.Equals(txtRetype.Text))
            {
                XtraMessageBox.Show("Password and Retype password must match!", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            dt = db.SelectTable("SELECT userID FROM tbluser WHERE librarianID='" + txtLibrarianID.Text.Replace("'","''") + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    XtraMessageBox.Show("The specified Librarian ID already has an existing account!", "Account Duplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            
            return true;
        }
    }
}
