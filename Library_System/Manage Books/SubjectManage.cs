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

namespace Library_System.Manage_Books
{
    public partial class subjectManage : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        DataTable dt;
        SaveSender ss;
        public subjectManage(SaveSender sSender)
        {
            InitializeComponent();
            ss = sSender;
            if (ss == SaveSender.DeleteSubject)
            {
                colSubjectName.OptionsColumn.ReadOnly = true;
                colIsSelected.Visible = true;
                lstSubjectItem.RowCellStyle -= lstSubjectItem_RowCellStyle;
                colIsSelected.Width = 60;
                colIsSelected.OptionsColumn.FixedWidth = true;
            }
            else if (ss == SaveSender.EditSubject)
            {
                colSubjectName.OptionsColumn.ReadOnly = false;
                colIsSelected.Visible = false;
            }
        }

        private void SubjectManage_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            dt = db.SelectTable("SELECT * FROM tblsubject");
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            DataColumn isEdited = new DataColumn("isEdited", typeof(int));
            isSelected.DefaultValue = false;
            isEdited.DefaultValue = 0;
            dt.Columns.Add(isSelected);
            dt.Columns.Add(isEdited);
            lstSubject.DataSource = dt;
        }

        private void lstSubjectItem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (ss == SaveSender.EditSubject)
            {
                string id = lstSubjectItem.GetRowCellValue(e.RowHandle, colSubjectID).ToString();
                string fieldName = lstSubjectItem.FocusedColumn.FieldName;
                dt.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                dt.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(id)).Select(s => s).Single()[fieldName] = e.Value;
            }
            if (ss == SaveSender.DeleteSubject)
            {
                string id = lstSubjectItem.GetRowCellValue(e.RowHandle, colSubjectID).ToString();
                dt.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
            }
        }

        private void lstSubjectItem_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (lstSubjectItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("-1"))
                    e.Appearance.BackColor = Color.Crimson;
                else if (lstSubjectItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("1"))
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                else if (lstSubjectItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("0"))
                    e.Appearance.BackColor = Color.Beige;
            }
            catch { }
        }

        private void lstSubjectItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            List<DataRow> dr;
            bool allValid = true;
            try
            {
                string id = lstSubjectItem.GetRowCellValue(e.RowHandle, colSubjectID).ToString();
                string toMessage = "";
                string subject = lstSubjectItem.GetRowCellValue(e.RowHandle, colSubjectName).ToString().Trim().ToLower();
                if (lstSubjectItem.GetRowCellValue(e.RowHandle, colSubjectName).ToString().Trim().Equals(""))
                {
                    allValid = false;
                    toMessage = "The subject name must not be empty";
                }
                dr = dt.AsEnumerable().Where(s => s["subjectName"].ToString().Trim().ToLower().Equals(subject) && !s["subjectID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr != null)
                {
                    if (dr.Count > 0)
                    {
                        allValid = false;
                        toMessage = "The subject you specified is already existing";
                    }
                }
                
                if (!allValid)
                {
                    dt.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
                    XtraMessageBox.Show(toMessage, "We encountered a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dt.AsEnumerable().Where(s => s["subjectID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                }
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
        }
        public void UpdateNow()
        {
            lstSubjectItem.HideEditor();
            List<string> queries = new List<string>();
            bool hasError = false;
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("1")).Select(s => s).ToList();
            foreach (DataRow r in dr)
            {
                if (!db.IsDataExist("tblsubject", "subjectName='" + r["subjectName"].ToString() + "' AND subjectID!=" + r["subjectID"].ToString()))
                {
                    r["isEdited"] = 0;
                    string query = "UPDATE tblsubject SET subjectName='" + r["subjectName"].ToString().Trim().Replace("'", "''") + "' WHERE subjectID=" + r["subjectID"].ToString();
                    queries.Add(query);
                }
                else
                {
                    hasError = true;
                    r["isEdited"] = -1;
                }
            }
            if (queries.Count > 0)
            {
                XtraMessageBox.Show((hasError ? "There is a conflict in updating your datas. The item marked in red contains issue. Refreshing List..." :
                "Update Success! All valid items was updated. Refreshing List"), (hasError ? "Data Mismatch" : "Update Successfully"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                db.InsertMultiple(queries);
            }
            db.UpdateList("tblsubject", "subjectID", new string[] { "subjectID", "subjectName" }, dt);
        }
        public void DeleteNow()
        {
            if (IsToDelete())
            {
                List<string> queries = new List<string>();
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
                foreach (DataRow r in dr)
                {
                    string query = "DELETE FROM tblsubject WHERE subjectID=" + r["subjectID"].ToString();
                    queries.Add(query);
                }
                db.InsertMultiple(queries);
                db.UpdateList("tblsubject", "subjectID", new string[] { "subjectID", "subjectName" }, dt);
            }
        }
        private bool IsToDelete()
        {
            string constraint = "";
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                foreach (DataRow r in dr)
                {
                    constraint += r["subjectID"].ToString() + ",";
                }
                if (constraint.Length > 0)
                    constraint = constraint.Remove(constraint.Length - 1);
                DataTable tbl = db.SelectTable("SELECT * FROM tblbook b INNER JOIN tblsubject s ON s.subjectID=b.subjectID WHERE s.subjectID IN(" + constraint + ") GROUP BY s.subjectID;");
                if (tbl != null)
                {
                    if (tbl.Rows.Count > 0)
                    {
                        string subjectConflict = "";
                        foreach (DataRow r in tbl.Rows)
                            subjectConflict += r["subjectName"].ToString() + "\n";
                        if (DialogResult.Yes == XtraMessageBox.Show("The following subject: \n" + subjectConflict + "has an associated record already." +
                            " Are you sure to delete those subject(s)? \nNote: The record(s) associated to the said subjects will also be deleted.",
                            "Subject is in Use", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
