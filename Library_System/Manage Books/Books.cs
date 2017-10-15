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
using Library_System.Borrowers_Menu;
using Logs;

namespace Library_System.Manage_Books
{
    public partial class Books : DevExpress.XtraEditors.XtraUserControl
    {
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        private ActivityLog log = new ActivityLog();
        private DataTable dt;
        private DataTable tblauthor;
        private SplitContainerControl scc;
        private SaveSender ss;
        private string selectedBookID = "-1";

        public Books(SaveSender ss)
        {
            InitializeComponent();
            
            this.ss = ss;
            
        }

        private void Books_Load(object sender, EventArgs e)
        {
            LoadList();
            lstBooksItem.BestFitColumns();
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            if (ss == SaveSender.EditBook)
            {
                lblForEdit.Visible = true;
                colIsSelected.Visible = false;
                lstBooksItem.OptionsBehavior.Editable = false;
            }
            else if (ss == SaveSender.DeleteBook)
            {
                lstBooksItem.OptionsBehavior.Editable = false;
                colIsSelected.Visible = true;
                colIsSelected.Width = 60;
                colIsSelected.OptionsColumn.FixedWidth = true;
            }
            else if (ss == SaveSender.ViewSearch)
            {
                colIsSelected.Visible = true;
                colIsSelected.Width = 60;
                colIsSelected.OptionsColumn.FixedWidth = true;
                lstBooksItem.OptionsBehavior.Editable = false;
            }
        }
        private void LoadList()
        {
            string query = "SELECT * FROM (tblbook b LEFT JOIN tblpublisher p ON b.publisherID=p.publisherID) LEFT JOIN tblsubject s ON b.subjectID=s.subjectID;";
            dt = db.SelectTable(query);
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            isSelected.DefaultValue = false;
            dt.Columns.Add(isSelected);
            lstBooks.DataSource = dt;

            tblauthor = db.SelectTable("SELECT * FROM tblauthor;");
            
        }

        private void lstBooksItem_Click(object sender, EventArgs e)
        {
            if (lstBooksItem.RowCount > 0)
            {
                DataTable dtAuthors = new DataTable();
                DataColumn authorID = new DataColumn("authorID", typeof(string));
                DataColumn authors = new DataColumn("authors", typeof(string));
                dtAuthors.Columns.Add(authorID);
                dtAuthors.Columns.Add(authors);
                string id = lstBooksItem.GetRowCellValue(lstBooksItem.FocusedRowHandle, colBookID).ToString();
                selectedBookID = id;
                try
                {
                    DataTable ba = db.SelectTable("SELECT * FROM tblbookauthor b INNER JOIN tblauthor a ON b.authorID=a.authorID WHERE bookID=" + id);
                    if (ba != null)
                    {
                        foreach (DataRow r in ba.Rows)
                        {
                            DataRow row = dtAuthors.NewRow();
                            row["authorID"] = r["authorID"].ToString();
                            if (r["fname"].ToString().Equals(""))
                                row["authors"] = r["corporation"].ToString();
                            else
                                row["authors"] = r["fname"].ToString() + (!r["mname"].ToString().Equals("") ? " " + r["mname"].ToString() + " " : " ") + r["lname"].ToString();
                            dtAuthors.Rows.Add(row);
                        }
                        Authors a = new Authors(dtAuthors);
                        a.Dock = DockStyle.Fill;
                        scc.Panel2.Enabled = true;
                        scc.Panel2.Controls.Clear();
                        scc.Panel2.Controls.Add(a);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            if (ss == SaveSender.DeleteBook || ss == SaveSender.ViewSearch)
            {
                if (lstBooksItem.FocusedColumn == colIsSelected)
                {
                    string id = lstBooksItem.GetRowCellValue(lstBooksItem.FocusedRowHandle, colBookID).ToString();
                    bool isSelected = bool.Parse(dt.AsEnumerable().Where(s => s["bookID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"].ToString());
                    dt.AsEnumerable().Where(s => s["bookID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = !isSelected;
                    lstBooksItem.SetRowCellValue(lstBooksItem.FocusedRowHandle, colIsSelected, !isSelected);
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (!txtSearch.Text.Trim().Equals(""))
                {
                    string constraints = "";
                    List<DataRow> dr = tblauthor.AsEnumerable().Where(s => (s["fname"].ToString() + (!s["mname"].ToString().Equals("")?" " + s["mname"].ToString() + " " :
                        " ") + s["lname"].ToString()).ToLower().Contains(txtSearch.Text.ToLower()) ||
                        s["corporation"].ToString().ToLower().Contains(txtSearch.Text.ToLower())).Select(s => s).ToList();
                    if (dr != null)
                    {
                        foreach (DataRow r in dr)
                        {
                            constraints += r["authorID"].ToString() + ",";
                        }
                    }
                    if (constraints.Length > 0)
                    {
                        DataTable toPost = dt.Clone();
                        toPost.Clear();
                        constraints = constraints.Remove(constraints.Length - 1);
                        DataTable search = db.SelectTable("SELECT bookID FROM tblbookauthor b INNER JOIN tblauthor a ON b.authorID=a.authorID WHERE b.authorID IN(" +
                            constraints + ") GROUP BY bookID;");
                        if (search != null)
                        {
                            foreach (DataRow r in search.Rows)
                            {
                                DataRow[] rows = dt.AsEnumerable().Where(s => s["bookID"].ToString().Equals(r["bookID"].ToString())).Select(s => s).ToArray();
                                foreach (DataRow row in rows)
                                    toPost.Rows.Add(row.ItemArray);
                            }
                        }
                        if (toPost.Rows.Count > 0)
                        {
                            lstBooks.DataSource = toPost;
                        }
                    }
                }
                else
                {
                    lstBooks.DataSource = dt;
                }
            }

        }

        private void lstBooksItem_DoubleClick(object sender, EventArgs e)
        {
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            if (ss == SaveSender.EditBook && lstBooksItem.RowCount > 0)
            {
                int count = ((Authors)scc.Panel2.Controls[0]).lstAuthorsItem.RowCount;
                string bookID = lstBooksItem.GetRowCellValue(lstBooksItem.FocusedRowHandle, colBookID).ToString();
                addBookInfo.editID = bookID;
                //frmMain.ss = SaveSender.EditBook;
                scc.Panel1.Controls.Clear();
                scc.Panel2.Controls.Clear();
                addBookInfo info = new addBookInfo();
                info.Dock = DockStyle.Fill;
                scc.SplitterPosition = info.Size.Width;
                scc.Panel1.Controls.Add(info);
                scc.Panel1.Enabled = true;
                addBookAuthor auth = new addBookAuthor();
                auth.Dock = DockStyle.Fill;
                auth.Size = scc.Size;
                scc.Panel2.Controls.Add(auth);
                
                scc.Panel2.Enabled = (count > 1?true:false);
                this.Dispose();
                /*
                 * ss = SaveSender.AddBook;
            ClearPanel();
            addBookInfo info = new addBookInfo();
            info.Dock = DockStyle.Fill;
            info.btnMultiAuthor.Checked = false;
            scMain.SplitterPosition = info.Size.Width;
            scMain.Panel1.Controls.Add(info);
            scMain.Panel1.Enabled = true;
            addBookAuthor auth = new addBookAuthor();
            auth.Dock = DockStyle.Fill;
            auth.Size = scMain.Size;
            scMain.Panel2.Controls.Add(auth);
            scMain.Panel2.Enabled = false;
            ClearCheckDoCheck(btnAddBooks);
                 */
            }
        }
        public void DeleteNow()
        {
            if(DialogResult.Yes == XtraMessageBox.Show("Are you sure you want to Delete the selected books?\nNote: Records associated to the books will also be deleted.",
                "Confirm Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                List<string> queries = new List<string>();
                List<string> bookIDs = new List<string>();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
                foreach (DataRow r in dr)
                {
                    string query = "DELETE FROM tblbook WHERE bookID=" + r["bookID"].ToString();
                    queries.Add(query);
                    bookIDs.Add(r["bookID"].ToString());
                }
                if (queries.Count > 0)
                {
                    log.DeleteBook(frmMain.userLoggedIn, bookIDs);
                    db.InsertMultiple(queries);
                    LoadList();
                }
            }
        }
        public void BorrowSelected()
        {
            int count =Convert.ToInt32( db.DataLookUp("quantity", "tblbook", "0", "bookID=" + selectedBookID));
            if (count > 0)
            {
                BorrowMenu bm = new BorrowMenu();
                bm.Dock = DockStyle.Fill;
                bm.bookID = this.selectedBookID;
                scc.SplitterPosition = 0;
                scc.Panel1.Controls.Clear();
                scc.Panel2.Controls.Clear();
                scc.Panel2.Controls.Add(bm);
                frmMain.ss = SaveSender.None;
            }
            else
                XtraMessageBox.Show("The book you selected is currently unavailable. Please consider searching for books related to it.", "Insufficient Stock",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void PrintSelected()
        {
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                Catalogs cats = new Catalogs();
                cats.PrepareData(dr);
            }
            else
                XtraMessageBox.Show("There is no selected book to print.", "No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
