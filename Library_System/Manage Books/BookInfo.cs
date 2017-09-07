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
using DevExpress.XtraGrid;
using MyClassCollection;

namespace Library_System
{
    public partial class addBookInfo : DevExpress.XtraEditors.XtraUserControl
    {
        AutoCompleteStringCollection pubNameCol;
        AutoCompleteStringCollection pubAddCol;
        AutoCompleteStringCollection subjectCol;
        AutoCompleteStringCollection fnames, mnames, lnames, corporations;
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        GridControl gc;
        SplitContainerControl scc;
        bool isPersonAuthor,isMultipleAuthor;

        //needed in saving
        List<string> bookAuthors;
        string subjectID,publisherID,callNumber,bookID;

        public addBookInfo()
        {
            InitializeComponent();
            SetAutoComplete();
        }
        private void SetAutoComplete()
        {
            //publisher
            pubNameCol = new AutoCompleteStringCollection();
            pubAddCol = new AutoCompleteStringCollection();
            DataTable dt = db.SelectTable("SELECT * FROM tblpublisher");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];
                        pubNameCol.Add(r["publisherName"].ToString());
                        pubAddCol.Add(r["address"].ToString());
                    }
                    txtPublisherName.MaskBox.AutoCompleteCustomSource = pubNameCol;
                    txtPublisherName.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtPublisherName.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtPublisherAddress.MaskBox.AutoCompleteCustomSource = pubAddCol;
                    txtPublisherAddress.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtPublisherAddress.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            //subject
            subjectCol = new AutoCompleteStringCollection();
            dt = db.SelectTable("SELECT * FROM tblsubject");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow r = dt.Rows[i];
                        subjectCol.Add(r["subjectName"].ToString());
                    }
                    txtSubject.MaskBox.AutoCompleteCustomSource = subjectCol;
                    txtSubject.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtSubject.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            dt = db.SelectTable("SELECT * FROM tblauthor WHERE corporation IS NULL");
            fnames = new AutoCompleteStringCollection();
            mnames = new AutoCompleteStringCollection();
            lnames = new AutoCompleteStringCollection();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        fnames.Add(r["fname"].ToString());
                        mnames.Add(r["mname"].ToString());
                        lnames.Add(r["lname"].ToString());
                    }
                    txtAuthorFname.MaskBox.AutoCompleteCustomSource = fnames;
                    txtAuthorFname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtAuthorFname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtAuthorMname.MaskBox.AutoCompleteCustomSource = mnames;
                    txtAuthorMname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtAuthorMname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtAuthorLname.MaskBox.AutoCompleteCustomSource = lnames;
                    txtAuthorLname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtAuthorLname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            dt = db.SelectTable("SELECT corporation FROM tblauthor WHERE fname IS NULL");
            corporations = new AutoCompleteStringCollection();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        corporations.Add(r["corporation"].ToString());
                    }
                    txtCorporate.MaskBox.AutoCompleteCustomSource = corporations;
                    txtCorporate.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtCorporate.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                }
            }
            //collection.AddRange(fnames);
            //txtAuthorFname.MaskBox.AutoCompleteCustomSource = collection;
            //txtAuthorFname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtAuthorFname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void optPerson_CheckedChanged(object sender, EventArgs e)
        {
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            if (optPerson.Checked)
            {
                gpbCorporate.Enabled = false;
                gpbPerson.Enabled = true;
                scc.Panel2.Enabled = btnMultiAuthor.Checked;
            }
            else
            {
                gpbCorporate.Enabled = true;
                gpbPerson.Enabled = false;
                scc.Panel2.Enabled = false;
            }
        }

        private void btnMultiAuthor_CheckedChanged(object sender, EventArgs e)
        {
            scc = (SplitContainerControl)((SplitGroupPanel)this.Parent).Parent;
            if (btnMultiAuthor.Checked)
            {
                txtAuthorFname.Enabled = false;
                txtAuthorLname.Enabled = false;
                txtAuthorMname.Enabled = false;
                btnMultiAuthor.Text = "Single Author";
                scc.Panel2.Enabled = true;
            }
            else
            {
                txtAuthorFname.Enabled = true;
                txtAuthorLname.Enabled = true;
                txtAuthorMname.Enabled = true;
                btnMultiAuthor.Text = "Multiple Author";
                scc.Panel2.Enabled = false;
            }
        }

        private void txtDewey_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.DecimalHandle(ref sender, ref e);
        }

        private void txtCatters_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.AlphaNumericOnly(ref sender, ref e);
        }

        private void txtAuthorFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }

        private void txtYearOfPub_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, true);
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.HypenatedNumberHandle(ref sender, ref e);
        }
        public void SaveDB()
        {
            TrimTextBoxes();
            isPersonAuthor = optPerson.Checked;
            isMultipleAuthor = btnMultiAuthor.Checked;
            GetAuthors();
            GetPublisherID();
            GetSubjectID();
            GenerateCallNumber();
            if (IsValid())
            {
                if (IsBookUnique())
                {
                    DoSaving();
                }
            }
            //XtraMessageBox.Show(isPersonAuthor.ToString(),isMultipleAuthor.ToString());
        }
        private void DoSaving()
        {
            string query = "INSERT INTO tblbook (callNumber, title, deweyDecimal, cattersNo, yearOfPublication, pages," +
                " volume, quantity, noteArea, typeOfIllustration, publisherID, ISBN, isCopyright, subjectID) ";
            query += "VALUES('" + callNumber + "','" + txtTitle.Text.Replace("'", "''") + "'," + (txtDewey.Text.Equals("") ? "NULL" : "'" + txtDewey.Text + "'") +
                "," + (txtCatters.Text.Equals("") ? "NULL" : "'" + txtCatters.Text + "'") +
                "," + (txtYearOfPub.Text.Equals("") ? "NULL" : txtYearOfPub.Text) +
                "," + (txtPage.Text.Equals("") ? "NULL" : txtPage.Text) +
                "," + (txtVolume.Text.Equals("") ? "NULL" : txtVolume.Text) + "," + txtQuantity.Text +
                "," + (txtNoteArea.Text.Equals("") ? "NULL" : "'" + txtNoteArea.Text.Replace("'", "''") + "'") +
                "," + (txtTypeOfIll.Text.Equals("") ? "NULL" : "'" + txtTypeOfIll.Text.Replace("'", "''") + "'") +
                "," + publisherID + "," + (txtISBN.Text.Equals("") ? "NULL" : "'" + txtISBN.Text + "'") +
                "," + (chkCopyright.Checked ? 1 : 0) + "," + subjectID + ");";
            db.InsertQuery(query);
            DataRow r = db.GetLastInsertItem("SELECT * FROM tblbook ORDER BY bookID DESC LIMIT 1");
            if (r != null)
                bookID = r["bookID"].ToString();
            List<string> queries = new List<string>();
            foreach (string s in bookAuthors)
                queries.Add("INSERT INTO tblbookauthor (bookID,authorID) VALUES(" + bookID + "," + s + ");");
            db.InsertMultiple(queries);
        }
        private void TrimTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextEdit)
                    (c as TextEdit).Text = (c as TextEdit).Text.Trim();
                if (c is MemoEdit)
                    (c as MemoEdit).Text = (c as MemoEdit).Text.Trim();
            }
        }
        private bool IsValid()
        {
            if (txtTitle.Text.Equals(""))
            {
                XtraMessageBox.Show("Title must not be empty","There are missing information(s)",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (txtQuantity.Text.Equals(""))
            {
                XtraMessageBox.Show("Please enter the quantity of book to be recorded", "There are missing information(s)",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (bookAuthors.Count == 0)
            {
                XtraMessageBox.Show("Please specify the author(s) for this book", "There are missing information(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (subjectID == null)
            {
                XtraMessageBox.Show("Please specify the subject for the book", "There are missing information(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (publisherID == null)
            {
                XtraMessageBox.Show("Please specify the publisher for the book", "There are missing information(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDewey.Text.Equals("") && txtCatters.Text.Equals("") && txtYearOfPub.Text.Equals(""))
            {
                XtraMessageBox.Show("You must provide atleas one of the following info : \n1. Dewey Decimal Nunber" +
                    "\n2. Catter's Number\n3. Year of publication", "There are missing information(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPage.Text.Equals(""))
            {
                XtraMessageBox.Show("Please specify the book's number of pages", "There are missing information(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool IsBookUnique()
        {
            DataTable dt = db.SelectTable("SELECT * FROM tblbook WHERE title='" + txtTitle.Text.Replace("'", "''") + "' AND volume " +
                (txtVolume.Text.Equals("") ? "IS NULL" : "=" + txtVolume.Text) + " LIMIT 1");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    DataTable bA = db.SelectTable("SELECT * FROM tblbookauthor WHERE bookID=" + r["bookID"].ToString());
                    if (dt != null)
                    {
                        if (bA.Rows.Count > 0)
                        {
                            if (bookAuthors.Count == bA.Rows.Count)
                            {
                                bool isExist = true;
                                foreach (DataRow row in bA.Rows)
                                {
                                    if (!bookAuthors.Contains(row["authorID"].ToString()))
                                        isExist = false;
                                }
                                if (isExist)
                                {
                                    XtraMessageBox.Show("The book that you want to save is already existing", "Book Duplication",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
        private void GetAuthors()
        {
            DataTable dt;
            bookAuthors = new List<string>();
            if (isPersonAuthor)
            {
                if (isMultipleAuthor)
                {
                    bookAuthors.AddRange(((addBookAuthor)scc.Panel2.Controls[0]).GetSelectedAuthors());
                }
                else
                {
                    dt = db.SelectTable("SELECT * FROM tblauthor WHERE fname ='" + txtAuthorFname.Text + "' AND " +
                    "mname ='" + txtAuthorMname.Text + "' AND lname='" + txtAuthorLname.Text + "' LIMIT 1");
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            DataRow r = dt.Rows[0];
                            bookAuthors.Add(r["authorID"].ToString());
                        }
                        else
                        {
                            if (!txtAuthorFname.Text.Equals("") && !txtAuthorLname.Text.Equals(""))
                            {
                                db.InsertQuery("INSERT INTO tblauthor (fname,mname,lname) VALUES('" + txtAuthorFname.Text + "','" +
                                txtAuthorMname.Text + "','" + txtAuthorLname.Text + "');");
                                DataRow r = db.GetLastInsertItem("SELECT authorID FROM tblauthor ORDER BY authorID DESC LIMIT 1");
                                bookAuthors.Add(r["authorID"].ToString());
                            }
                        }
                    }
                }
            }
            else
            {
                dt = db.SelectTable("SELECT * FROM tblauthor WHERE corporation ='" + txtCorporate.Text.Replace("'", "''") + "' LIMIT 1");
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow r = dt.Rows[0];
                        bookAuthors.Add(r["authorID"].ToString());
                    }
                    else
                    {
                        if (!txtCorporate.Text.Equals(""))
                        {
                            db.InsertQuery("INSERT INTO tblauthor(corporation) VALUES('" + txtCorporate.Text.Replace("'", "''") + "');");
                            DataRow r = db.GetLastInsertItem("SELECT authorID FROM tblauthor ORDER BY authorID DESC LIMIT 1");
                            bookAuthors.Add(r["authorID"].ToString());
                        }
                    }
                }
            }
        }
        private void GetPublisherID()
        {
            DataTable dt = db.SelectTable("SELECT publisherID FROM tblpublisher WHERE publisherName='" + txtPublisherName.Text.Replace("'", "''") +
                "' AND address='" + txtPublisherAddress.Text.Replace("'", "''") + "' LIMIT 1");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    publisherID = r["publisherID"].ToString();
                }
                else
                {
                    if (!txtPublisherName.Text.Equals("") && !txtPublisherAddress.Text.Equals(""))
                    {
                        db.InsertQuery("INSERT INTO tblpublisher(publisherName,address) VALUES('" + txtPublisherName.Text.Replace("'", "''") +
                        "','" + txtPublisherAddress.Text.Replace("'", "''") + "');");
                        DataRow r = db.GetLastInsertItem("SELECT * FROM tblpublisher ORDER BY publisherID DESC LIMIT 1");
                        publisherID = r["publisherID"].ToString();
                    }
                }
            }
        }
        private void GetSubjectID()
        {
            DataTable dt = db.SelectTable("SELECT subjectID FROM tblsubject WHERE subjectName='" + txtSubject.Text.Replace("'", "''") +
                "' LIMIT 1");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    subjectID = r["subjectID"].ToString();
                }
                else
                {
                    if (!txtSubject.Text.Equals(""))
                    {
                        db.InsertQuery("INSERT INTO tblsubject (subjectName) VALUES('" + txtSubject.Text.Replace("'", "''") + "');");
                        DataRow r = db.GetLastInsertItem("SELECT subjectID FROM tblsubject ORDER BY subjectID DESC LIMIT 1");
                        subjectID = r["subjectID"].ToString();
                    }
                }
            }
        }
        private void GenerateCallNumber() 
        {
            callNumber = "";
            if (!txtDewey.Text.Equals(""))
                callNumber += txtDewey.Text + " ";
            if (!txtCatters.Text.Equals(""))
                callNumber += txtCatters.Text + " ";
            if (!txtYearOfPub.Text.Equals(""))
                callNumber += (chkCopyright.Checked ? "c" : "") + txtYearOfPub.Text;
            callNumber = callNumber.Trim();
        }
    }
}
