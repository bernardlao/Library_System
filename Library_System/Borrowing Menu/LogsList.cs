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

namespace Library_System.Borrowing_Menu
{
    public partial class LogsList : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        DataTable dt;
        string logTable = "";
        string logType = "";
        SplitContainerControl scc;
        public LogsList()
        {
            InitializeComponent();
        }

        private void LogsList_Load(object sender, EventArgs e)
        {
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            LoadList();
            cmbField.SelectedIndex = 0;
            cmbSearchBy.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
        }
        private void LoadList()
        {
            string query = "SELECT logID,l.userID,(if( l.userID=0 , 'Admin',if(l.userID=-1,'Guest',librarianID)))"+
                " AS 'librarianID',(if( l.userID=0 , 'Admin',if(l.userID=-1,'Guest',CONCAT(fname,' ',lname))))"+
                " AS 'fullname',logTable,logType,logDescription,logDate FROM tbllogs l LEFT JOIN tbluser u ON l.userID=u.userID ORDER BY logDate DESC;";
            dt = db.SelectTable(query);
            lstLogs.DataSource = dt;
        }

        private void cmbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * All0
Users1
Login/Logout2
Borrowers3
Books4
Subjects5
Publishers6
Authors7
Penalty Sanctions8
             * */
            switch (cmbField.SelectedIndex)
            {
                case 0:
                    logTable = "";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All"}); break;
                case 1:
                    logTable = "User";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Register User","Update User","Reset Password"}); break;
                case 2:
                    logTable = "User Log";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Login","Logout"}); break;
                case 3:
                    logTable = "Borrower";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Register Borrower","Update Borrower","Approve Borrower"}); break;
                case 4:
                    logTable = "Book";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Add Book","Update Book","Delete Book"}); break;
                case 5:
                    logTable = "Subject";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Update Subject","Delete Subject"}); break;
                case 6:
                    logTable = "Publisher";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Update Publisher","Delete Publisher"}); break;
                case 7:
                    logTable = "Author";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.AddRange(new string[]{"All","Update Author","Delete Author"}); break;
                case 8:
                    logTable = "Penalty";
                    cmbType.Properties.Items.Clear();
                    cmbType.Properties.Items.Add("Apply Sanction");break;
            }
            logType = "";
            cmbType.SelectedIndex = 0;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbType.SelectedIndex == 0)
                    logType = "";
                else
                    logType = cmbType.Properties.Items[cmbType.SelectedIndex].ToString();
            }
            catch { logType = ""; }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool hasDate = false;
            if (dtpFrom.DateTime <= dtpTo.DateTime)
            {
                if (!dtpFrom.DateTime.ToShortDateString().Equals("1/1/0001") && !dtpTo.DateTime.ToShortDateString().Equals("1/1/0001"))
                {
                    hasDate = true;
                }
            }
            List<DataRow> dr;
            if (!logTable.Equals(""))
                dr = dt.AsEnumerable().Where(s => s["logTable"].ToString().Equals(logTable)).Select(s => s).ToList();
            else
                dr = dt.AsEnumerable().Select(s => s).ToList();
            if (!logType.Equals(""))
                dr = dr.Where(s => s["logType"].ToString().Equals(logType)).Select(s => s).ToList();
            else
                dr = dr.Select(s => s).ToList();
            //if (logTable.Equals("Login/Logout"))
            //    dr = dt.AsEnumerable().Where(s => s["logTable"].ToString().Equals("Login") || s["logTable"].ToString().Equals("Logout")).ToList();
            //else if (logTable.Equals(""))
            //    dr = dt.AsEnumerable().Where(s => s["logType"].ToString().Contains(logType)).ToList();
            //else
            //    dr = dt.AsEnumerable().Where(s => s["logTable"].ToString().Equals(logTable)).ToList();
            //dr = dr.Where(s => s["logType"].ToString().Equals(logType)).ToList();
            if (hasDate)
            {
                DateTime from = dtpFrom.DateTime;
                DateTime to = dtpTo.DateTime;
                dr = dr.Where(s => Convert.ToDateTime(Convert.ToDateTime(s["logDate"].ToString()).ToShortDateString()) >= from &&
                    Convert.ToDateTime(Convert.ToDateTime(s["logDate"].ToString()).ToShortDateString()) <= to).Select(s => s).ToList();
            }
            if (cmbSearchBy.SelectedIndex == 0)
                dr = dr.Where(s => s["librarianID"].ToString().Contains(txtLoggedInUserID.Text)).ToList();
            else
                dr = dr.Where(s => s["fullname"].ToString().Contains(txtLoggedInUserID.Text)).ToList();
            if (dr.Count > 0)
                lstLogs.DataSource = dr.CopyToDataTable();
            else
                lstLogs.DataSource = new DataTable();
        }

        private void lstLogsItem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            try
            {
                string description = lstLogsItem.GetRowCellValue(lstLogsItem.FocusedRowHandle, colLogDescription).ToString();
                description = description.Replace(";", Environment.NewLine);
                MemoEdit des = new MemoEdit();
                des.Text = description;
                LabelControl lc = new LabelControl();
                lc.Text = "Description Details";
                lc.Location = new Point(0, 0);
                des.Location = new Point(0, lc.Size.Height + 5);
                des.Size = new Size(scc.Panel2.Width, scc.Panel2.Height - 5 - lc.Size.Height);
                des.Anchor = (AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right|AnchorStyles.Top);
                scc.Panel2.Controls.Clear();
                scc.Panel2.Enabled = true;
                scc.Panel2.Controls.Add(lc);
                scc.Panel2.Controls.Add(des);
            }
            catch (Exception ex)
            { XtraMessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            lstLogs.DataSource = dt;
        }
    }
}
