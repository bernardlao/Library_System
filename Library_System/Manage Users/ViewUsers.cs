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
                lstUsersItem.Columns[0].VisibleIndex = 0;
                for (int i = 1; i < lstUsersItem.Columns.Count; i++)
                {
                    lstUsersItem.Columns[i].OptionsColumn.ReadOnly = true;
                }
            }
        }

        private void viewUsers_Load(object sender, EventArgs e)
        {
            LoadList();
            
        }
        public void LoadList()
        {
            if(currSS == SaveSender.ResetPassword)
                dt = db.SelectTable("SELECT * FROM tbluser");
            else
                dt = db.SelectTable("SELECT * FROM tbluser WHERE userID != 1");
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
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[4]).ToString().Equals(""))
                    allValid = false;
                if (lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[6]).ToString().Equals(""))
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
                XtraMessageBox.Show("There are still unresolved issue on your update!", "Error on Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rs = dt.AsEnumerable().Where(s => s["isEdited"].ToString().Equals("1")).Select(s => s).ToList();
                if (rs.Count == 0)
                    XtraMessageBox.Show("There is nothing to be updated!", "No Updates Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    UpdateDB();
            }
        }
        private void UpdateDB()
        {
            List<string> queries = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                if (r["isEdited"].ToString().Equals("1"))
                {
                    string query = "UPDATE tbluser SET username='" + r["username"].ToString() + "', password='', salt='', librarianID='" + r["librarianID"].ToString() +
                        "', fname='" + r["fname"].ToString() + "', mname='" + r["mname"].ToString() + "', lname='" + r["lname"].ToString() + "' WHERE userID=" +
                        r["userID"].ToString() + ";";
                    queries.Add(query);
                }
            }
            db.InsertMultiple(queries);
        }
        public void ResetPasswordNow()
        {
            List<string> queries = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                if (r["isSelected"].ToString().Equals("True"))
                {
                    string query = "UPDATE tbluser SET password='', salt='' WHERE userID=" + r["userID"].ToString();
                    queries.Add(query);
                }
            }
            db.InsertMultiple(queries);
        }

        private void lstUsersItem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (currSS == SaveSender.ResetPassword)
            {
                string id = lstUsersItem.GetRowCellValue(e.RowHandle, lstUsersItem.Columns[1]).ToString();
                dt.AsEnumerable().Where(s => s["userID"].ToString().Equals(id)).Select(s => s).Single()["isSelected"] = e.Value;
            }
        }
    }
}
