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

namespace Library_System.Borrowers_Menu
{
    public partial class RegisterBorrower : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();

        public RegisterBorrower()
        {
            InitializeComponent();
        }

        private void RegisterBorrower_Load(object sender, EventArgs e)
        {

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
                txtBorrowerID.Text + "','" + type + "','" + txtFname.Text + "','" + txtMname.Text + "','" + txtLname.Text + "','" + 
                dtpBday.DateTime.ToString("yyyy-MM-dd") + "','" + txtAddress.Text.Replace("'","''") + "','Request');";
            int res = db.InsertQuery(query);
            if (res != -1)
            {
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
                XtraMessageBox.Show("Please input your ID#.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFname.Text.Equals(""))
            {
                XtraMessageBox.Show("Please input your firstname.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLname.Text.Equals(""))
            {
                XtraMessageBox.Show("Please input your lastname.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpBday.EditValue == null)
            {
                XtraMessageBox.Show("Please input your birthday.", "Information Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
