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
    public partial class publisherManage : DevExpress.XtraEditors.XtraUserControl
    {
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        private DataTable dt;
        private SaveSender ss;

        public publisherManage(SaveSender ss)
        {
            InitializeComponent();
            this.ss = ss;
            if (ss == SaveSender.EditPublisher)
            {
                colIsSelected.Visible = false;
                colPublisherName.OptionsColumn.ReadOnly = false;
                colAddress.OptionsColumn.ReadOnly = false;
            }
            else if (ss == SaveSender.DeletePublisher)
            {
                colIsSelected.Visible = true;
                colPublisherName.OptionsColumn.ReadOnly = true;
                colAddress.OptionsColumn.ReadOnly = true;
                lstPublisherItem.RowCellStyle -= lstPublisherItem_RowCellStyle;
                colIsSelected.Width = 60;
                colIsSelected.OptionsColumn.FixedWidth = true;
            }
        }

        private void publisherManage_Load(object sender, EventArgs e)
        {
            LoadList();
            lstPublisherItem.BestFitColumns();
        }
        private void LoadList()
        {
            dt = db.SelectTable("SELECT * FROM tblpublisher");
            DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
            DataColumn isEdited = new DataColumn("isEdited", typeof(int));
            isSelected.DefaultValue = false;
            isEdited.DefaultValue = 0;
            dt.Columns.Add(isSelected);
            dt.Columns.Add(isEdited);
            lstPublisher.DataSource = dt;
        }

        private void lstPublisherItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string id = lstPublisherItem.GetRowCellValue(e.RowHandle, colPublisherID).ToString();
            List<DataRow> dr;
            bool allValid = true;
            try
            {
                string changedVal = lstPublisherItem.GetRowCellValue(e.RowHandle, colPublisherName).ToString().Trim();
                string toMessage = "";
                if (changedVal.Equals(""))
                {
                    toMessage = "The publisher name must not be empty!";
                    allValid = false;
                }
                dr = dt.AsEnumerable().Where(s => s["publisherName"].ToString().Trim().Equals(changedVal) &&
                    !s["publisherID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr.Count > 0)
                {
                    allValid = false;
                    toMessage = "The publisher name you specified is already existing.";
                    //dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
                }
                if (allValid)
                    dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                else
                {
                    dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
                    XtraMessageBox.Show(toMessage, "We encountered a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void lstPublisherItem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string id = lstPublisherItem.GetRowCellValue(e.RowHandle, colPublisherID).ToString();
            if (ss == SaveSender.EditPublisher)
            {
                string fieldName = lstPublisherItem.FocusedColumn.FieldName;
                dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()[fieldName] = e.Value;
                dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
            }
            else if (ss == SaveSender.DeletePublisher)
            {
                dt.AsEnumerable().Where(s => s["publisherID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
            }
        }

        private void lstPublisherItem_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (lstPublisherItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("-1"))
                    e.Appearance.BackColor = Color.Crimson;
                else if (lstPublisherItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("1"))
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                else if (lstPublisherItem.GetRowCellValue(e.RowHandle, colIsEdited).ToString().Equals("0"))
                    e.Appearance.BackColor = Color.Beige;
            }
            catch { }
        }

        public void UpdateNow()
        {
            lstPublisherItem.HideEditor();
            bool hasError = false;
            List<string> queries = new List<string>();
            List<DataRow> toUpdate = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("1")).Select(s => s).ToList();
            foreach (DataRow r in toUpdate)
            {
                if (!db.IsDataExist("tblpublisher", "publisherName='" + r["publisherName"].ToString() + "' AND publisherID!=" + r["publisherID"].ToString()))
                {
                    r["isEdited"] = 0;
                    string query = "UPDATE tblpublisher SET publisherName = '" + r["publisherName"].ToString().Trim().Replace("'", "''") +
                    "', address='" + r["address"].ToString().Trim().Replace("'", "''") + "' WHERE publisherID =" + r["publisherID"].ToString();
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
            db.UpdateList("tblpublisher", "publisherID", new string[] { "publisherID", "publisherName", "address" }, dt);
        }

        public void DeleteNow()
        {
            List<string> queries = new List<string>();
            List<DataRow> toDelete = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (toDelete.Count > 0)
            {
                if (IsAllowedToDelete(toDelete))
                {
                    foreach (DataRow r in toDelete)
                    {
                        string publisherToDefault = "UPDATE tblbook SET publisherID=0 WHERE publisherID=" + r["publisherID"].ToString() + ";";
                        queries.Add(publisherToDefault);
                        string query = "DELETE FROM tblpublisher WHERE publisherID=" + r["publisherID"].ToString();
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

        private bool IsAllowedToDelete(List<DataRow> dr)
        {
            string constraints = "";
            foreach (DataRow r in dr)
                constraints += r["publisherID"].ToString() + ",";
            if (constraints.Length > 0)
                constraints = constraints.Remove(constraints.Length - 1);
            DataTable hasBooks = db.SelectTable("SELECT * FROM tblbook b INNER JOIN tblpublisher p ON b.publisherID=p.publisherID WHERE p.publisherID IN(" + constraints + ") GROUP BY p.publisherID;");
            if (hasBooks != null)
            {
                if (hasBooks.Rows.Count > 0)
                {
                    string publisherConflict = "";
                    foreach (DataRow r in hasBooks.Rows)
                        publisherConflict += r["publisherName"].ToString() + "\n";
                    if (DialogResult.Yes == XtraMessageBox.Show("The following publisher: \n" + publisherConflict + "has an associated record already." +
                            " Are you sure to delete those publisher(s)? \nNote: The record(s) associated to the said pubisher will be emptied.",
                            "Publisher is in Use", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
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
