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
    public partial class BorrowedBooks : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        DataTable dt;
        SaveSender ss;
        DateTime current = Convert.ToDateTime("01/01/0001");

        public BorrowedBooks(SaveSender ss)
        {
            InitializeComponent();
            this.ss = ss;
        }

        private void BorrowedBooks_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadList();
            lstBorrowedItem.BestFitColumns();
            if (ss == SaveSender.BorrowList)
            {
                colIsSelected.Visible = false;
                colDateBorrowed.Visible = false;
                colDateAllowance.Visible = false;
                colDateReturned.Visible = false;
                colLibrarianID1.Visible = false;
                colApproverName.Visible = false;
                colLibrarianID2.Visible = false;
                colReceiverName.Visible = false;
                colStatus.Visible = false;
                colScheduledReturn.Visible = false;
                grpFilter.Enabled = false;
            }
            else if (ss == SaveSender.ReceiveList)
            {
                colLibrarianID2.Visible = false;
                colReceiverName.Visible = false;
                colDateReturned.Visible = false;
                colStatus.Visible = false;
                grpDateAllowance.Visible = false;
                gpbLegends.Visible = true;
                grpFilter.Enabled = false;
            }
            else if (ss == SaveSender.CheckTransactionRecord)
            {
                colIsSelected.Visible = false;
                grpDateAllowance.Visible = false;
            }
        }
        private void LoadComboBox() 
        {
            cmbSearhBy.Properties.Items.AddRange(new string[] { "Call Number", "Title",
                "Borrower ID", "Borrowed By", "Approved By", "Received By" });
            cmbSearhBy.SelectedIndex = 0;
        }
        private void LoadList()
        {
            string query = "";
            if (ss == SaveSender.CheckTransactionRecord)
            {
                query = "SELECT b.bookID,borrowedBookID,callNumber,title,bo.borrowerID,CONCAT(bo.fname,' ', bo.lname) AS" +
                " 'bfullname', bb.quantity,dateBorrowed,dateReturned,dateAllowance,u1.librarianID AS 'librarianID1', " +
                "CONCAT(u1.fname,' ', u1.lname) AS 'afullname', u2.librarianID AS 'librarianID2', " +
                "CONCAT(u2.fname,' ', u2.lname) AS 'rfullname', bb.status AS 'status' FROM" +
                " (((tblborrowedbook bb INNER JOIN tblbook b ON bb.bookID=b.bookID) INNER JOIN tblborrower bo ON" +
                " bb.borrowerID=bo.borrowerID) INNER JOIN tbluser u1 ON bb.ApproverUserID=u1.userID) INNER JOIN tbluser" +
                " u2 ON bb.ReceiverUserID=u2.userID WHERE bb.status='Received' ORDER BY bb.dateReturned DESC;";
            }
            else if (ss == SaveSender.BorrowList)
            {
                query = "SELECT b.bookID,borrowedBookID,callNumber,title,bo.borrowerID,CONCAT(bo.fname,' ', bo.lname) AS 'bfullname', bb.quantity FROM " +
                    "(tblborrowedbook bb INNER JOIN tblbook b ON bb.bookID=b.bookID) INNER JOIN tblborrower bo ON bb.borrowerID=bo.borrowerID " +
                    "WHERE bb.status='Request' ORDER BY bb.borrowedBookID DESC;";
            }
            else if (ss == SaveSender.ReceiveList)
            {
                query = "SELECT b.bookID,borrowedBookID,callNumber,title,bo.borrowerID,CONCAT(bo.fname,' ', bo.lname) AS" +
                " 'bfullname', bb.quantity,dateBorrowed,dateReturned,dateAllowance,u1.librarianID AS 'librarianID1', " +
                "CONCAT(u1.fname,' ', u1.lname) AS 'afullname',  bb.status AS 'status' FROM" +
                " ((tblborrowedbook bb INNER JOIN tblbook b ON bb.bookID=b.bookID) INNER JOIN tblborrower bo ON" +
                " bb.borrowerID=bo.borrowerID) INNER JOIN tbluser u1 ON bb.ApproverUserID=u1.userID WHERE bb.status='Approved'" +
                " ORDER BY bb.dateBorrowed DESC;";
            }
            dt = db.SelectTable(query);
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            isSelected.DefaultValue = false;
            if (ss == SaveSender.ReceiveList || ss == SaveSender.CheckTransactionRecord)
            {
                DataColumn scheduledReturn = new DataColumn("scheduledReturn", typeof(DateTime));
                scheduledReturn.DefaultValue = new DateTime();
                dt.Columns.Add(scheduledReturn);
                SetScheduledReturnValues();
            }
            dt.Columns.Add(isSelected);
            lstBorrowed.DataSource = dt;
            
        }
        private void SetScheduledReturnValues()
        {
            foreach (DataRow r in dt.Rows)
            {
                DateTime schedDate = hm.GetReturnDate(Convert.ToDateTime(r["dateBorrowed"].ToString()), Convert.ToInt32(r["dateAllowance"].ToString()));
                r["scheduledReturn"] = schedDate;
            }
        }
        private void lstBorrowedItem_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column == colIsSelected)
            {
                string id = lstBorrowedItem.GetRowCellValue(e.RowHandle, colBorrowedBookID).ToString();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["borrowedBookID"].ToString().Equals(id)).ToList();
                if (dr.Count > 0)
                {
                    bool isCheck = bool.Parse(dr[0]["isSelected"].ToString());
                    dr[0]["isSelected"] = !isCheck;
                }
            }
            
        }

        public void ApproveBorrowRequest()
        {
            if (!txtDateAllowance.Text.Equals("") && !txtDateAllowance.Text.Equals("0"))
            {
                int allowed = Convert.ToInt32(txtDateAllowance.Text);
                string id = lstBorrowedItem.GetRowCellValue(lstBorrowedItem.FocusedRowHandle, colBorrowedBookID).ToString();
                if (allowed > 0)
                {
                    if (CanBorrow(id))
                    {
                        DateTime now = db.GetServerDateTime();

                        string approverUserID = frmMain.userLoggedIn;
                        string query = "UPDATE tblborrowedbook SET dateBorrowed='" + now.ToString("yyyy-MM-dd HH:mm:ss") + "', dateAllowance=" + allowed +
                            ", ApproverUserID=" + approverUserID + ", status='Approved' WHERE borrowedBookID=" + id + ";";
                        int res = db.InsertQuery(query);
                        if (res != -1)
                            XtraMessageBox.Show("Request approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadList();
                    }
                }
                else
                    XtraMessageBox.Show("The date allowance must not be empty and must be greater than 0.", "Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                XtraMessageBox.Show("The date allowance must not be empty and must be greater than 0.", "Information Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private bool CanBorrow(string id)
        {
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["borrowedBookID"].ToString().Equals(id)).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                string borrowQuantity = dr[0]["quantity"].ToString();
                string bookID = dr[0]["bookID"].ToString();
                string bookQuantity = db.DataLookUp("quantity", "tblbook", "0", "bookID=" + bookID);
                int reqQuantity = Convert.ToInt32(borrowQuantity);
                int stockQuantity = Convert.ToInt32(bookQuantity);
                if (reqQuantity <= stockQuantity)
                {
                    int result = stockQuantity - reqQuantity;
                    db.InsertQuery("UPDATE tblbook SET quantity=" + result + " WHERE bookID=" + bookID);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("You don't have enough stock for the requested book.","Not Enough Stock",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public void RejectBorrowRequest()
        {
            string id = lstBorrowedItem.GetRowCellValue(lstBorrowedItem.FocusedRowHandle, colBorrowedBookID).ToString();
            string query = "UPDATE tblborrowedbook SET status='Rejected' WHERE borrowedBookID=" + id + ";";
            int res = db.InsertQuery(query);
            if (res != -1)
                XtraMessageBox.Show("Request rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadList();
        }
        public void ReceiveBookReturns()
        {
            List<string> queries = new List<string>();
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                DateTime now = db.GetServerDateTime();
                foreach (DataRow r in dr)
                {
                    string id = r["borrowedBookID"].ToString();
                    string dateBorrowed = r["dateBorrowed"].ToString();
                    int diff = hm.GetDateDifferenceWithoutWeekends(Convert.ToDateTime(dateBorrowed), now);
                    int dateAllowed = Convert.ToInt32(r["dateAllowance"].ToString());
                    diff = dateAllowed - diff;
                    if (diff < 0)
                        db.InsertQuery("INSERT INTO tblpenalty (borrowedBookID,status) VALUES(" + id + ",'Penalized');");

                    
                    string receiverUserID = frmMain.userLoggedIn;
                    string status = "Received";
                    string query = "UPDATE tblborrowedbook SET receiverUserID=" + receiverUserID + ", dateReturned='" + now.ToString("yyyy-MM-dd HH:mm:ss") +
                        "', status='" + status + "' WHERE borrowedBookID=" + id + ";";
                    queries.Add(query);

                    ReturnBookStocks(r["bookID"].ToString(), r["quantity"].ToString());
                }
                if (queries.Count > 0)
                {
                    db.InsertMultiple(queries);
                    XtraMessageBox.Show("Book(s) received successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                }
            }

        }
        private void ReturnBookStocks(string bookID, string quantity)
        {
            string stocks = db.DataLookUp("quantity", "tblbook", "0", "bookID=" + bookID);
            int total = Convert.ToInt32(stocks) + Convert.ToInt32(quantity);
            db.InsertQuery("UPDATE tblbook SET quantity=" + total + " WHERE bookID=" + bookID);
        }
        private void txtDateAllowance_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, true);
        }

        private void lstBorrowedItem_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (ss == SaveSender.ReceiveList)
            {
                if (current.ToString("MM/dd/yyyy").Equals("01/01/0001"))
                    current = db.GetServerDateTime();
                string dateBorrowed = lstBorrowedItem.GetRowCellValue(e.RowHandle, colDateBorrowed).ToString();
                int diff = hm.GetDateDifferenceWithoutWeekends(Convert.ToDateTime(dateBorrowed), current);
                int dateAllowed = Convert.ToInt32(lstBorrowedItem.GetRowCellValue(e.RowHandle, colDateAllowance).ToString());
                diff = dateAllowed - diff;
                if (diff < 0)
                    e.Appearance.BackColor = Color.Crimson;
                else if (diff == 0)
                    e.Appearance.BackColor = Color.Goldenrod;
                else if (diff > 0)
                    e.Appearance.BackColor = Color.LightGreen;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            List<DataRow> dr = dt.AsEnumerable().Select(s => s).ToList();
            bool hasSearchText = false, hasBorrowedFilter = false, hasReturnedFilter = false;
            string searchBy=GetSearchBy();
            if (!txtSearchKey.Text.Equals(""))
                hasSearchText = true;
            if (!dtpBFrom.DateTime.ToShortDateString().Equals("1/1/0001") && !dtpBTo.DateTime.ToShortDateString().Equals("1/1/0001"))
                hasBorrowedFilter = true;
            if (!dtpRFrom.DateTime.ToShortDateString().Equals("1/1/0001") && !dtpRTo.DateTime.ToShortDateString().Equals("1/1/0001"))
                hasReturnedFilter = true;
            if (hasSearchText)
                dr = dr.Where(s => s[searchBy].ToString().ToLower().Contains(txtSearchKey.Text.ToLower())).Select(s => s).ToList();
            if (hasBorrowedFilter && !hasReturnedFilter)
                dr = dr.Where(s => Convert.ToDateTime(Convert.ToDateTime(s["dateBorrowed"].ToString()).ToShortDateString()) >= dtpBFrom.DateTime &&
                    Convert.ToDateTime(Convert.ToDateTime(s["dateBorrowed"].ToString()).ToShortDateString()) <= dtpBTo.DateTime)
                    .Select(s => s).ToList();
            else if (!hasBorrowedFilter && hasReturnedFilter)
                dr = dr.Where(s => Convert.ToDateTime(Convert.ToDateTime(s["dateReturned"].ToString()).ToShortDateString()) >= dtpRFrom.DateTime &&
                    Convert.ToDateTime(Convert.ToDateTime(s["dateReturned"].ToString()).ToShortDateString())  <= dtpRTo.DateTime)
                    .Select(s => s).ToList();
            else if (hasBorrowedFilter && hasReturnedFilter)
                dr = dr.Where(s => (Convert.ToDateTime(Convert.ToDateTime(s["dateBorrowed"].ToString()).ToShortDateString()) >= dtpBFrom.DateTime &&
                    Convert.ToDateTime(Convert.ToDateTime(s["dateBorrowed"].ToString()).ToShortDateString()) <= dtpBTo.DateTime) ||
                    (Convert.ToDateTime(Convert.ToDateTime(s["dateReturned"].ToString()).ToShortDateString()) >= dtpRFrom.DateTime &&
                    Convert.ToDateTime(Convert.ToDateTime(s["dateReturned"].ToString()).ToShortDateString()) <= dtpRTo.DateTime))
                    .Select(s => s).ToList();
            DataTable d = new DataTable();
            if(dr.Count > 0)
               d = dr.ToArray().CopyToDataTable();
            lstBorrowed.DataSource = d;
        }
        private string GetSearchBy()
        {//"Call Number", "Title","Borrower ID", "Borrowed By", "Approver ID", "Approved By", "Receiver ID", "Received By" 
            string selected = cmbSearhBy.Properties.Items[cmbSearhBy.SelectedIndex].ToString();
            switch (selected)
            {
                case "Call Number": return "callNumber";
                case "Title": return "title";
                case "Borrower ID": return "borrowerID";
                case "Borrowed By": return "bfullname";
                case "Approved By": return "afullname";
                case "Received By": return "rfullname";
                default: return "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBorrowed.DataSource = dt;
        }
    }
}
