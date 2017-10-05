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
using RibbonSupport;

namespace Library_System.Borrowing_Menu
{
    public partial class Penalties : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        SaveSender ss;
        DataTable dt;
        public Penalties(SaveSender ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void Penalties_Load(object sender, EventArgs e)
        {
            LoadList();
            lstPenaltyItem.BestFitColumns();
            if (ss == SaveSender.CheckAndSanctionPenalty)
            {
                gpbCount.Visible = false;
            }
            else if (ss == SaveSender.CheckAllPenalties)
            {
                colIsSelected.Visible = false;
                colLibrarianID.Visible = false;
                colReceiverName.Visible = false;
            }
        }
        private void LoadList()
        {
            string query = "SELECT penaltyID, bo.borrowerID,CONCAT(bo.fname,' ',bo.lname) AS 'bfullname'," + 
                " b.callNumber, b.title, bb.quantity, bb.dateReturned, u2.librarianID, CONCAT(u2.fname,' ',u2.lname)" + 
                " AS 'rfullname', p.status, bb.dateBorrowed,bb.dateAllowance FROM (((tblpenalty p INNER JOIN" + 
                " tblborrowedbook bb ON p.borrowedBookID=bb.borrowedBookID) INNER JOIN tblbook b ON bb.bookID=b.bookID)" + 
                " INNER JOIN tblborrower bo ON bb.borrowerID=bo.borrowerID) INNER JOIN tbluser u2 ON bb.ReceiverUserID=u2.userID" +
                (ss == SaveSender.CheckAllPenalties ? " ORDER BY dateReturned DESC;" : " WHERE p.status='Penaltied' ORDER BY dateReturned DESC;");
            dt = db.SelectTable(query);
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            isSelected.DefaultValue = false;
            DataColumn daysExceed = new DataColumn("daysExceed", typeof(int));
            daysExceed.DefaultValue = 0;
            dt.Columns.Add(isSelected);
            dt.Columns.Add(daysExceed);
            CountExeededDays();
            lstPenalty.DataSource = dt;
        }
        private void CountExeededDays()
        {
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        int datePassed = hm.GetDateDifferenceWithoutWeekends(Convert.ToDateTime(r["dateBorrowed"].ToString()), Convert.ToDateTime(r["dateReturned"].ToString()));
                        int allowed = Convert.ToInt32(r["dateAllowance"].ToString());
                        int result = datePassed - allowed;
                        r["daysExceed"] = result;
                    }
                }
            }
        }
        private void lstPenaltyItem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colIsSelected)
            {
                string id = lstPenaltyItem.GetRowCellValue(e.RowHandle, colPenaltyID).ToString();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["penaltyID"].ToString().Equals(id)).ToList();
                if (dr.Count > 0)
                {
                    bool isCheck = bool.Parse(dr[0]["isSelected"].ToString());
                    dr[0]["isSelected"] = !isCheck;
                }
            }
        }
        public void ApplySanction()
        {
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                List<string> qs = new List<string>();
                foreach (DataRow r in dr)
                {
                    string query = "UPDATE tblpenalty SET status='Sanctioned' WHERE penaltyID=" + r["penaltyID"].ToString() + ";";
                    qs.Add(query);
                }
                if (qs.Count > 0)
                {
                    db.InsertMultiple(qs);
                    LoadList();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int count = lstPenaltyItem.RowCount;
            XtraMessageBox.Show("There are " + count + (count > 1 ? " penalties " : " penalty ") + "in display", "Number of Penalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
