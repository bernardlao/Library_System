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

namespace Library_System.Manage_Users
{
    public partial class viewUsers : DevExpress.XtraEditors.XtraUserControl
    {
        MySQLDBUtilities db = new MySQLDBUtilities();
        HelperMethods hm = new HelperMethods();
        SaveSender currSS;
        DataTable dt;

        public viewUsers(SaveSender ss)
        {
            InitializeComponent();
            currSS = ss;
            if (ss == SaveSender.AddUser) { lstUsersItem.OptionsBehavior.Editable = false; }
            else if (ss == SaveSender.UpdateUser) { lstUsersItem.OptionsBehavior.Editable = true; }
            else if (ss == SaveSender.ResetPassword)
            {
                lstUsersItem.RowCellStyle -= lstUsersItem_RowCellStyle;
                lstUsersItem.Columns[0].VisibleIndex = 0;
                for (int i = 1; i < lstUsersItem.Columns.Count; i++)
                {
                    lstUsersItem.Columns[i].OptionsColumn.ReadOnly = true;
                }
                colSelected.Width = 60;
                colSelected.OptionsColumn.FixedWidth = true;
            }
        }

        private void viewUsers_Load(object sender, EventArgs e)
        {
            LoadList();
            //colFirstname.RealColumnEdit.KeyPress += name_KeyPress;
            //colLastname.RealColumnEdit.KeyPress += name_KeyPress;
            //colMiddlename.RealColumnEdit.KeyPress += name_KeyPress;
            //colUsername.RealColumnEdit.KeyPress += user_KeyPress;
            
        }
        public void LoadList()
        {
            if(currSS == SaveSender.ResetPassword)
                dt = db.SelectTable("SELECT * FROM tbluser");
            else
                dt = db.SelectTable("SELECT * FROM tbluser WHERE username != 'admin'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataColumn isSelected = new DataColumn("isSelected", typeof(bool));
                    isSelected.DefaultValue = false;
                    dt.Columns.Add(isSelected);
                    DataColumn isEdited = new DataColumn("isEdited", typeof(int));
                    isEdited.DefaultValue = 0;
                    dt.Columns.Add(isEdited);
                    lstUsers.DataSource = dt;
                }
            }
        }

        private void lstUsersItem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //lstUsersItem.SetColumnError(lstUsersItem.Columns[2], "Error daw");
            bool allValid = true;
            try
            {
                string id = lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[1]).ToString();
                List<DataRow> r = null;
                r = dt.AsEnumerable().Where(s => s["username"].ToString().Equals(lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns["username"]).ToString()) &&
                                    !s["userID"].ToString().Equals(id)).ToList(); ;
                if (r.Count > 0)
                    allValid = false;
                r = dt.AsEnumerable().Where(s => s["librarianID"].ToString().Equals(lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns["librarianID"]).ToString()) &&
                        !s["userID"].ToString().Equals(id)).ToList();
                if (r.Count > 0)
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[2]).ToString().Equals(""))
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[3]).ToString().Equals(""))
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[4]).ToString().Trim().Equals(""))
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[6]).ToString().Trim().Equals(""))
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[2]).ToString().Equals("admin", StringComparison.CurrentCultureIgnoreCase))
                    allValid = false;
                if (allValid)
                    dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                else
                    dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = -1;
            }
            catch (StackOverflowException ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void lstUsersItem_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns["isEdited"]).ToString().Equals("-1"))
                    e.Appearance.BackColor = Color.Crimson;
                else if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns["isEdited"]).ToString().Equals("1"))
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                else if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns["isEdited"]).ToString().Equals("0"))
                    e.Appearance.BackColor = Color.Beige;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "ERROR");
            }
        }
        public void UpdateNow()
        {
            List<DataRow> rs = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("-1")).Select(s => s).ToList();
            if (rs.Count > 0)
            {
                XtraMessageBox.Show("Those items colored red will not be updated.", "Has Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateDB();
            }
            else
                UpdateDB();
        }
        private void UpdateDB()
        {
            lstUsersItem.HideEditor();
            List<string> queries = new List<string>();
            bool hasError = false;
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("1")).Select(s => s).ToList();
            foreach (DataRow r in dr)
            {
                if (db.IsDataExist("tbluser", "username='" + r["username"].ToString() + "' AND userID !=" + r["userID"].ToString()))
                {
                    r["isEdited"] = -1;
                    hasError = true;
                }
                else
                {
                    r["isEdited"] = 0;
                    string query = "UPDATE tbluser SET username='" + r["username"].ToString() + "', password='" + r["password"].ToString() +
                        "', salt='" + r["salt"].ToString() + "', librarianID='" + r["librarianID"].ToString() +
                        "', fname='" + r["fname"].ToString().Trim() + "', mname='" + r["mname"].ToString().Trim() + "', lname='" + r["lname"].ToString().Trim() + "' WHERE userID=" +
                        r["userID"].ToString() + ";";
                    queries.Add(query);
                }
            }
            if (queries.Count > 0)
            {
                db.InsertMultiple(queries);
                XtraMessageBox.Show((hasError ? "There is a conflict in updating your datas. The item marked in red contains issue. Refreshing List..." :
                "Update Success! All valid items was updated. Refreshing List"), (hasError ? "Data Mismatch" : "Update Successfully"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.UpdateList("tbluser", "userID", new string[] { "userID", "username", "password", "librarianID", "fname", "lname", "lname" },  dt);
            dt.AsEnumerable().Where(s => s["username"].ToString().Equals("admin")).Select(s => s).Single().Delete();
            
        }
        public void ResetPasswordNow()
        {
            List<string> queries = new List<string>();
            List<DataRow> dr = dt.AsEnumerable().Where(s => s["isSelected"].ToString().Equals("True")).Select(s => s).ToList();
            if (dr.Count > 0)
            {
                foreach (DataRow r in dr)
                {
                    string query = "UPDATE tbluser SET password='', salt='' WHERE userID=" + r["userID"].ToString();
                    queries.Add(query);
                }
                db.InsertMultiple(queries);
                db.UpdateList("tbluser", "userID", new string[] { "userID", "username", "password", "librarianID", "fname", "lname", "lname" }, dt);
                dt.AsEnumerable().Where(s => s["username"].ToString().Equals("admin")).Select(s => s).Single().Delete();
            }
        }

        private void lstUsersItem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (currSS == SaveSender.ResetPassword)
            {
                string id = lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[1]).ToString();
                dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
            }
            if (currSS == SaveSender.UpdateUser)
            {
                string id = lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[1]).ToString();
                string fieldName = lstUsersItem.FocusedColumn.FieldName;
                dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()["isEdited"] = 1;
                dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()[fieldName] = e.Value;
            }
        }
        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.AlphaNumericOnly(ref sender, ref e);
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }

        private void lstUsersItem_ShownEditor(object sender, EventArgs e)
        {
            if (lstUsersItem.FocusedColumn.FieldName == "username")
            {
                lstUsersItem.ActiveEditor.KeyPress += user_KeyPress;
            }
            else if (lstUsersItem.FocusedColumn.FieldName == "fname" || lstUsersItem.FocusedColumn.FieldName == "mname" || lstUsersItem.FocusedColumn.FieldName == "fname")
            {
                lstUsersItem.ActiveEditor.KeyPress += name_KeyPress;
            }
        }
    }
}
