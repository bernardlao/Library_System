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
using RibbonSupport;
using MyClassCollection;

namespace Library_System.Borrowers_Menu
{
    public partial class Borrowers : DevExpress.XtraEditors.XtraUserControl
    {
        private SaveSender ss;
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private DataTable dt;
        private SplitContainerControl scc;

        public Borrowers(SaveSender ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            LoadList();
            lstBorrowerItem.BestFitColumns();
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            if (ss == SaveSender.EditBorrower)
            {
                lblForEdit.Visible = true;
                colIsSelected.Visible = false;
            }
        }
        public void LoadList()
        {
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            isSelected.DefaultValue = false;
            if (ss == SaveSender.ApproveBorrower)
                dt = db.SelectTable("SELECT * FROM tblborrower WHERE status='Request';");
            else if (ss == SaveSender.DeleteBorrower || ss == SaveSender.EditBorrower)
                dt = db.SelectTable("SELECT * FROM tblborrower");
            dt.Columns.Add(isSelected);
            lstBorrower.DataSource = dt;
        }

        private void lstBorrowerItem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colIsSelected)
            {
                string id = lstBorrowerItem.GetRowCellValue(e.RowHandle, colBorrowerID).ToString();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["borrowerID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr.Count > 0)
                {
                    bool checkStatus = bool.Parse(dr[0]["isSelected"].ToString());
                    dr[0]["isSelected"] = !checkStatus;
                }
            }
        }
        public void ApproveRegistration()
        {
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                List<string> queries = new List<string>();
                foreach (DataRow r in dr)
                {
                    string query = "UPDATE tblborrower SET status='Approved' WHERE borrowerID='" + r["borrowerID"].ToString() + "';";
                    queries.Add(query);
                }
                if (queries.Count > 0)
                {
                    db.InsertMultiple(queries);
                    LoadList();
                }
            }
        }
        public void DeleteBorrower()
        {
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                if (DialogResult.Yes == XtraMessageBox.Show("Are you sure you want to delete the selected account? Note : Records associated with " +
                "the deleted account will also be deleted.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    List<string> queries = new List<string>();
                    foreach (DataRow r in dr)
                    {
                        string query = "DELETE FROM tblborrower WHERE borrowerID='" + r["borrowerID"].ToString() + "';";
                        queries.Add(query);
                    }
                    if (queries.Count > 0)
                    {
                        db.InsertMultiple(queries);
                        LoadList();
                    }
                }
            }
        }

        private void lstBorrowerItem_DoubleClick(object sender, EventArgs e)
        {
            if (ss == SaveSender.EditBorrower)
            {
                string id = lstBorrowerItem.GetRowCellValue(lstBorrowerItem.FocusedRowHandle, colBorrowerID).ToString();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["borrowerID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr.Count > 0)
                {
                    DataRow r = dr[0];
                    RegisterBorrower rb = new RegisterBorrower();

                    if (r["borrowerType"].ToString().Equals("Teacher"))
                        rb.optTeacher.Checked = true;
                    else if (r["borrowerType"].ToString().Equals("Others"))
                        rb.optOthers.Checked = true;
                    rb.txtBorrowerID.Text = r["borrowerID"].ToString();
                    rb.txtFname.Text = r["fname"].ToString();
                    rb.txtLname.Text = r["lname"].ToString();
                    rb.txtMname.Text = r["mname"].ToString();
                    rb.txtAddress.Text = r["address"].ToString();
                    rb.dtpBday.DateTime = Convert.ToDateTime(r["bdate"].ToString());
                    rb.editID = id;
                    rb.txtBorrowerID.Enabled = false;
                    rb.optOthers.Enabled = false;
                    rb.optStudent.Enabled = false;
                    rb.optTeacher.Enabled = false;

                    rb.Dock = DockStyle.Fill;
                    scc.SplitterPosition = scc.Size.Width - rb.Size.Width;
                    scc.Panel2.Enabled = true;
                    scc.Panel2.Controls.Clear();
                    scc.Panel2.Controls.Add(rb);
                }
            }
        }
    }
}
