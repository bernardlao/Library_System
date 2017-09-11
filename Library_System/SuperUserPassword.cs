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
    public partial class SuperUserPassword : DevExpress.XtraEditors.XtraForm
    {
        public string adminPassword;
        private string salt;
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        public static bool allowEntry = false;

        public SuperUserPassword()
        {
            InitializeComponent();
        }

        private void SuperUserPassword_Load(object sender, EventArgs e)
        {
            allowEntry = false;
            DataTable dt = db.SelectTable("SELECT * FROM tbluser WHERE userID = 1 LIMIT 1");
            DataRow r = dt.Rows[0];
            adminPassword = r["password"].ToString();
            salt = r["salt"].ToString();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (adminPassword.Equals(hm.GenerateSHA256(txtPassword.Text + salt)))
                {
                    allowEntry = true;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Invalid password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.AlphaNumericOnly(ref sender, ref e);
        }
    }
}