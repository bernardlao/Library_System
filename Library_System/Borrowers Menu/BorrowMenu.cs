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
    public partial class BorrowMenu : DevExpress.XtraEditors.XtraUserControl
    {
        public string bookID;
        private bool Isvalid = false;
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        private string borrowerID;

        public BorrowMenu()
        {
            InitializeComponent();
        }

        private void BorrowMenu_Load(object sender, EventArgs e)
        {
            LoadBookInfo();
        }
        private void LoadBookInfo()
        {
            DataTable dt = db.SelectTable("SELECT * FROM (tblbookauthor ba INNER JOIN tblbook b ON ba.bookID=b.bookID) INNER JOIN tblauthor a ON ba.authorID=a.authorID" +
                " WHERE b.bookID=" + bookID);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    string title = "";
                    string authors = "";
                    foreach (DataRow r in dt.Rows)
                    {
                        title = r["title"].ToString();
                        if (r["fname"].ToString().Equals(""))
                            authors += r["corporation"].ToString();
                        else
                            authors += r["fname"].ToString() + (r["mname"].ToString().Equals("") ? " " : " " + r["mname"].ToString() + " ") + r["lname"].ToString() + Environment.NewLine;
                    }
                    txtTitle.Text = title;
                    txtAuthors.Text = authors;
                }
            }
        }
        private void tmSetter_Tick(object sender, EventArgs e)
        {
            gpbBorrowInfo.Enabled = Isvalid;
        }

        private void txtBorrowerID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                DataTable dt = db.SelectTable("SELECT * FROM tblborrower WHERE borrowerID='" + txtBorrowerID.Text.Trim().Replace("'", "''") + "' AND status='Approved' LIMIT 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow r = dt.Rows[0];
                        string fullname = r["fname"].ToString() + (r["mname"].ToString().Equals("") ? " " : " " + r["mname"].ToString() + " ") + r["lname"].ToString();
                        borrowerID = r["borrowerID"].ToString();
                        lblFullname.Text = fullname;
                        Isvalid = true;
                    }
                }
            }
            else
            {
                Isvalid = false;
                lblFullname.Text = "";
            }
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, true);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (Isvalid)
            {
                if (!txtQuantity.Text.Equals(""))
                {
                    int request = Convert.ToInt32(txtQuantity.Text);
                    int stocks = Convert.ToInt32(db.DataLookUp("quantity", "tblbook", "-1", "bookID=" + bookID));
                    if (request <= stocks && request > 0)
                    {
                        string query = "INSERT INTO tblborrowedbook(bookID,borrowerID,quantity,status) VALUES(" + bookID + ",'" + borrowerID + "'," +
                            request + ",'Request');";
                        int res = db.InsertQuery(query);
                        if (res != -1)
                        {
                            XtraMessageBox.Show("Request Sent. Please contact our Librarian for Borrow Approval.",
                                "Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                    }
                }
            }
        }

        private void txtBorrowerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.PossibleIDHandler(ref sender, ref e);
        }
    }
}
