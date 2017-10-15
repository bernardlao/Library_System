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
using Logs;

namespace Library_System.Borrowers_Menu
{
    public partial class RegisterBorrower : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        ActivityLog log = new ActivityLog();
        public string editID;

        public RegisterBorrower()
        {
            InitializeComponent();
        }

        private void RegisterBorrower_Load(object sender, EventArgs e)
        {
            if (editID == null)
            {
                dtpBday.DateTime = DateTime.Now;
                dtpBday.Properties.MaxValue = db.GetServerDateTime();
            }
        }

        private void optStudent_CheckedChanged(object sender, EventArgs e)
        {
            txtBorrowerID.Text = "";
            if (optStudent.Checked)
                txtBorrowerID.Properties.MaxLength = 12;
            if (optTeacher.Checked)
                txtBorrowerID.Properties.MaxLength = 7;
            if (optOthers.Checked)
                txtBorrowerID.Properties.MaxLength = 0;
        }

        private void txtBorrowerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (optStudent.Checked || optTeacher.Checked)
                hm.TextHandle(ref sender, ref e, true);
            if (optOthers.Checked)
                hm.PossibleIDHandler(ref sender, ref e);
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }
        public void SaveNow()
        {
            hm.TrimTextEdit(this);
            if (IsAllValid())
            {
                if (IsUserUnique())
                {
                    SaveDB();
                }
            }
        }
        public void UpdateNow()
        {
            if (editID != null)
            {
                hm.TrimTextEdit(this);
                if (IsAllValid())
                {
                    string query = "UPDATE tblborrower SET fname='" + txtFname.Text + "', mname=" + (txtMname.Text.Equals("")?"NULL":"'" + txtMname.Text + "'") + 
                        ", lname='" + txtLname.Text + "', bdate='" + dtpBday.DateTime.ToString("yyyy-MM-dd") + "', address='" + txtAddress.Text.Replace("'","''") +
                        "' WHERE borrowerID='" + editID + "';";
                    log.UpdateBorrower(editID, txtFname.Text, txtMname.Text, txtLname.Text);
                    db.InsertQuery(query);
                }
            }
        }
        private void SaveDB()
        {
            string type = "";
            if (optOthers.Checked)
                type = "Others";
            else if (optStudent.Checked)
                type = "Student";
            else if (optTeacher.Checked)
                type = "Teacher";
            
            string query = "INSERT INTO tblborrower(borrowerID, borrowerType, fname, mname, lname, bdate, address, status) VALUES('" +
                txtBorrowerID.Text + "','" + type + "','" + txtFname.Text + "'," + (txtMname.Text.Equals("")? "NULL":"'" + txtMname.Text + "'") + ",'" + txtLname.Text + "','" + 
                dtpBday.DateTime.ToString("yyyy-MM-dd") + "','" + txtAddress.Text.Replace("'","''") + "','Request');";
            int res = db.InsertQuery(query);
            if (res != -1)
            {
                log.RegisterBorrower(txtBorrowerID.Text, txtFname.Text, txtMname.Text, txtLname.Text);
                XtraMessageBox.Show("Please contact the librarian to confirm your registration.", "Registration Request Sent",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                hm.ClearTextEdit(this);
            }
        }
        private bool IsAllValid()
        {
            if (optStudent.Checked)
            {
                if (txtBorrowerID.Text.Length != 12)
                {
                    XtraMessageBox.Show("Your ID # (LRN) must be a 12-digit number.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (optTeacher.Checked)
            {
                if (txtBorrowerID.Text.Length != 7)
                {
                    XtraMessageBox.Show("Your ID # (Employee number) must be a 7-digit number.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtBorrowerID.Text.Equals(""))
            {
                XtraMessageBox.Show("Please specify your ID#.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFname.Text.Equals(""))
            {
                XtraMessageBox.Show("Please specify your firstname.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLname.Text.Equals(""))
            {
                XtraMessageBox.Show("Please specify your lastname.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpBday.EditValue == null)
            {
                XtraMessageBox.Show("Please specify your birthday.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAddress.Text.Equals(""))
            {
                XtraMessageBox.Show("Please specify your address.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool IsUserUnique()
        {
            if (db.IsDataExist("tblborrower", "borrowerID='" + txtBorrowerID.Text + "'"))
            {
                XtraMessageBox.Show("Your Information already exist. If you are sure that you are not registered yet with the information you give." +
                    "Please contact our Current Librarian.", "Account Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
