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

namespace Library_System.Manage_Books
{
    public partial class authorManage : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        DataTable dt;
        SaveSender ss;

        public authorManage(SaveSender ss)
        {
            InitializeComponent();
            this.ss = ss;
            if (ss == SaveSender.EditAuthor)
            { 
            }
            else if (ss == SaveSender.DeleteAuthor)
            {
                colIsSelected.Visible = true;
                colIsSelected2.Visible = true;
                colFname.OptionsColumn.ReadOnly = true;
                colMname.OptionsColumn.ReadOnly = true;
                colLname.OptionsColumn.ReadOnly = true;
                colCorporation.OptionsColumn.ReadOnly = true;
                colFname2.OptionsColumn.ReadOnly = true;
                colMname2.OptionsColumn.ReadOnly = true;
                colLname2.OptionsColumn.ReadOnly = true;
                colCorporation2.OptionsColumn.ReadOnly = true;
                colIsSelected.OptionsColumn.FixedWidth = true;
                colIsSelected2.OptionsColumn.FixedWidth = true;
                colIsSelected.Width = 60;
                colIsSelected2.Width = 60;
                personView.RowCellStyle -= personView_RowCellStyle;
                corporateView.RowCellStyle -= personView_RowCellStyle;
            }
        }

        private void AuthorManage_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dt = db.SelectTable("SELECT * FROM tblauthor");
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            DataColumn isEdited = new DataColumn("isEdited", typeof(int));
            DataColumn authorType = new DataColumn("authorType", typeof(string));
            isSelected.DefaultValue = false;
            isEdited.DefaultValue = 0;
            authorType.DefaultValue = "Person";
            dt.Columns.Add(isSelected);
            dt.Columns.Add(isEdited);
            dt.Columns.Add(authorType);

            foreach (DataRow r in dt.Rows)
            {
                string s = r["fname"].ToString();
                if (r["fname"].ToString().Equals(""))
                    r["authorType"] = "Corporate";
                else
                    r["authorType"] = "Person";
            }

            DataRow[] dr = dt.AsEnumerable().Where(s => s["authorType"].ToString().Equals("Person")).Select(s => s).ToArray();
            if(dr.Length > 0)
                lstAuthor.DataSource = dr.CopyToDataTable();
        }

        private void btnIsPersonView_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void RefreshList()
        {
            if (btnIsPersonView.Checked)
            {
                btnIsPersonView.Text = "View Person Authors";
                lstAuthor.MainView = corporateView;
                DataRow[] dr = dt.AsEnumerable().Where(s => s["authorType"].ToString().Equals("Corporate")).Select(s => s).ToArray();
                if (dr.Length > 0)
                    lstAuthor.DataSource = dr.CopyToDataTable();
            }
            else
            {
                btnIsPersonView.Text = "View Corporate Authors";
                lstAuthor.MainView = personView;
                DataRow[] dr = dt.AsEnumerable().Where(s => s["authorType"].ToString().Equals("Person")).Select(s => s).ToArray();
                if (dr.Length > 0)
                    lstAuthor.DataSource = dr.CopyToDataTable();
            }
        }

        private void personView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (btnIsPersonView.Checked)
                {
                    if (corporateView.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("-1"))
                        e.Appearance.BackColor = Color.Crimson;
                    else if (corporateView.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("1"))
                        e.Appearance.BackColor = Color.DeepSkyBlue;
                    else if (corporateView.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("0"))
                        e.Appearance.BackColor = Color.Beige;
                }
                else
                {
                    if (personView.GetRowCellValue(e.RowHandle, colIsEdited2).ToString().Equals("-1"))
                        e.Appearance.BackColor = Color.Crimson;
                    else if (personView.GetRowCellValue(e.RowHandle, colIsEdited2).ToString().Equals("1"))
                        e.Appearance.BackColor = Color.DeepSkyBlue;
                    else if (personView.GetRowCellValue(e.RowHandle, colIsEdited2).ToString().Equals("0"))
                        e.Appearance.BackColor = Color.Beige;
                }
            }
            catch { }
        }

        private void personView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (btnIsPersonView.Checked)
            {
                string id = corporateView.GetRowCellValue(e.RowHandle, colAuthorID).ToString();
                if (ss == SaveSender.EditAuthor)
                {
                    string fieldName = corporateView.FocusedColumn.FieldName;
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()[fieldName] = e.Value;
                }
                else if (ss == SaveSender.DeleteAuthor)
                {
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
                }
            }
            else
            {
                string id = personView.GetRowCellValue(e.RowHandle, colAuthorID2).ToString();
                if (ss == SaveSender.EditAuthor)
                {
                    string fieldName = personView.FocusedColumn.FieldName;
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()[fieldName] = e.Value;
                }
                else if (ss == SaveSender.DeleteAuthor)
                {
                    dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
                }
            }
        }

        private void personView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            List<DataRow> dr;
            bool allValid = true;
            string toMessage = "";
            try
            {
                if (btnIsPersonView.Checked)
                {
                    string id = corporateView.GetRowCellValue(e.RowHandle, colAuthorID).ToString();
                    string cname = corporateView.GetRowCellValue(e.RowHandle, colCorporation).ToString().Trim().ToLower();
                    if (cname.Equals(""))
                    {
                        allValid = false;
                        toMessage = "The corporate name must not be empty!";
                    }
                    dr = dt.AsEnumerable().Where(s => s["corporation"].ToString().Trim().ToLower().Equals(cname) &&
                        !s["authorID"].ToString().Equals(id)).Select(s => s).Select(s => s).ToList();
                    if (dr.Count > 0)
                    {
                        allValid = false;
                        toMessage = "The corporate name you specified was already in the list!";
                    }
                    if (allValid)
                        dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                    else
                    {
                        dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
                        XtraMessageBox.Show(toMessage, "We encountered a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string id = personView.GetRowCellValue(e.RowHandle, colAuthorID2).ToString();
                    string fname = personView.GetRowCellValue(e.RowHandle, colFname2).ToString().Trim().ToLower();
                    string mname = personView.GetRowCellValue(e.RowHandle, colMname2).ToString().Trim().ToLower();
                    string lname = personView.GetRowCellValue(e.RowHandle, colLname2).ToString().Trim().ToLower();
                    if (fname.Equals("") || lname.Equals(""))
                    {
                        allValid = false;
                        toMessage = "The first and last name must not be emptied!";
                    }
                    dr = dt.AsEnumerable().Where(s => s["fname"].ToString().Trim().ToLower().Equals(fname) &&
                        s["mname"].ToString().Trim().ToLower().Equals(mname) &&
                        s["lname"].ToString().Trim().ToLower().Equals(lname) &&
                        !s["authorID"].ToString().Equals(id)).Select(s => s).ToList();
                    if (dr.Count > 0)
                    {
                        allValid = false;
                        toMessage = "The name you specified was already existing.";
                    }
                    if (allValid)
                        dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                    else
                    {
                        dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
                        XtraMessageBox.Show(toMessage, "We encountered a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshList();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
        }

        private void personView_ShownEditor(object sender, EventArgs e)
        {
            if (personView.FocusedColumn.FieldName == "fname" || personView.FocusedColumn.FieldName == "mname" || personView.FocusedColumn.FieldName == "lname")
                personView.ActiveEditor.KeyPress += name_KeyPress;
            
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }

        public void UpdateNow()
        {
            personView.HideEditor();
            corporateView.HideEditor();
            List<string> queries = new List<string>();
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("1")).Select(s => s).ToList();
            bool hasError = false;
            if (dr.Count > 0)
            {
                foreach (DataRow r in dr)
                {
                    string query = "";
                    if (r["fname"].ToString().Equals(""))
                    {
                        if (!db.IsDataExist("tblauthor", "corporation='" + r["corporation"].ToString().Trim().Replace("'", "''") + "' AND authorID!=" + r["authorID"].ToString()))
                            query = "UPDATE tblauthor SET corporation='" + r["corporation"].ToString().Trim().Replace("'", "''") + "' WHERE authorID=" + r["authorID"].ToString();
                        else 
                        {
                            hasError = false;
                            r["isEdited"] = -1;
                        }
                    }
                    else
                    {
                        if (!db.IsDataExist("tblauthor", "fname='" + r["fname"].ToString().Trim() + "' AND mname='" + r["mname"].ToString().Trim() +
                            "' AND lname='" + r["lname"].ToString().Trim() + "' AND authorID!=" + r["authorID"].ToString()))
                            query = "UPDATE tblauthor SET fname='" + r["fname"].ToString().Trim() + "', mname='" + r["mname"].ToString().Trim() +
                                "', lname='" + r["lname"].ToString() + "' WHERE authorID=" + r["authorID"].ToString();
                        else
                        {
                            hasError = false;
                            r["isEdited"] = -1;
                        }
                    }
                    if (!query.Equals(""))
                    {
                        r["isEdited"] = -1;
                        queries.Add(query);
                    }
                }
                if (queries.Count > 0)
                {
                    XtraMessageBox.Show((hasError ? "There is a conflict in updating your datas. The item marked in red contains issue. Refreshing List..." :
                    "Update Success! All valid items was updated. Refreshing List"), (hasError ? "Data Mismatch" : "Update Successfully"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.InsertMultiple(queries);
                }
                db.UpdateList("tblauthor", "authorID", new string[] { "authorID", "fname", "mname", "lname", "corporation" }, dt);
                SetAuthorType();
                RefreshList();
            }
        }
        public void DeleteNow()
        {
            List<string> queries = new List<string>();
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                if (IsToDelete(dr))
                {
                    foreach (DataRow r in dr)
                    {
                        string query = "DELETE FROM tblauthor WHERE authorID=" + r["authorID"].ToString();
                        queries.Add(query);
                    }
                    if (queries.Count > 0)
                        db.InsertMultiple(queries);
                    db.UpdateList("tblauthor", "authorID", new string[] { "authorID", "fname", "mname", "lname", "corporation" }, dt);
                    SetAuthorType();
                    RefreshList();
                }
            }
        }
        private void SetAuthorType()
        {
            foreach (DataRow r in dt.Rows)
            {
                if (r["fname"].ToString().Equals(""))
                    r["authorType"] = "Corporate";
                else
                    r["authorType"] = "Person";
            }
        }
        private bool IsToDelete(List<DataRow> dr)
        {
            string cons = "";
            foreach (DataRow r in dr)
                cons += r["authorID"].ToString() + ",";
            if (cons.Length > 0)
                cons = cons.Remove(cons.Length - 1);
            DataTable bookAuthor = db.SelectTable("SELECT * FROM tblbookauthor b INNER JOIN tblauthor a ON b.authorID=a.authorID WHERE a.authorID IN(" + cons +
                ") GROUP BY a.authorID");
            if (bookAuthor != null)
            {
                if (bookAuthor.Rows.Count > 0)
                {
                    string authorConflict = "";
                    foreach (DataRow r in bookAuthor.Rows)
                    {
                        if (r["fname"].ToString().Equals(""))
                            authorConflict += r["corporation"].ToString() + "\n";
                        else
                            authorConflict += r["fname"].ToString() + (r["mname"].ToString().Length > 0 ? " " + r["mname"].ToString() + " " : " ") + r["lname"].ToString() + "\n";
                    }
                    if (DialogResult.Yes == XtraMessageBox.Show("The following author: \n" + authorConflict + "has an associated record already." +
                            " Are you sure to delete those author(s)? \nNote: The record(s) associated to the said author will also be deleted.",
                            "Author is in Use", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        List<string> ids = new List<string>();
                        foreach (DataRow r in bookAuthor.Rows)
                        {
                            if (!ids.Contains(r["bookID"].ToString()))
                                ids.Add(r["bookID"].ToString());
                        }
                        foreach (string id in ids)
                            db.InsertQuery("DELETE FROM tblbook WHERE bookID=" + id);
                        return true;
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
