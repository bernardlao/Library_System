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

namespace Library_System
{
    public partial class addBookAuthor : DevExpress.XtraEditors.XtraUserControl
    {
        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collection2 = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collection3 = new AutoCompleteStringCollection();
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        List<int> checkIndexes = new List<int>();
        DataTable dt = new DataTable();

        public static List<string> ids;
        public addBookAuthor()
        {
            InitializeComponent();
        }

        private void addBookAuthor_Load(object sender, EventArgs e)
        {
            dt = db.SelectTable("SELECT authorID,fname,mname,lname FROM tblauthor WHERE corporation IS NULL");
            DataColumn isSelected = new DataColumn("isSelected",typeof(bool));
            isSelected.DefaultValue = false;
            dt.Columns.Add(isSelected);
            SetAutoComplete(dt);
            lstBookAuthor.DataSource = dt;
            if (frmMain.ss == RibbonSupport.SaveSender.EditBook && ids != null)
                SetSelected();
            lstBookAuthorItem.BestFitColumns();
        }
        private void SetSelected()
        {
            foreach (string id in ids)
            {
                List<DataRow> dr = dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr.Count > 0)
                    dr[0]["isSelected"] = true;
            }
        }
        private void SetAutoComplete(DataTable dt)
        {
            string[] fnames = new string[dt.Rows.Count];
            string[] mnames = new string[dt.Rows.Count];
            string[] lnames = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow r = dt.Rows[i];
                fnames[i] = r["fname"].ToString();
                mnames[i] = r["mname"].ToString();
                lnames[i] = r["lname"].ToString();
            }
            collection.AddRange(fnames);
            txtAuthorFname.MaskBox.AutoCompleteCustomSource = collection;
            txtAuthorFname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuthorFname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            collection2 = new AutoCompleteStringCollection();
            collection2.AddRange(mnames);
            txtAuthorMname.MaskBox.AutoCompleteCustomSource = collection2;
            txtAuthorMname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuthorMname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            collection3 = new AutoCompleteStringCollection();
            collection3.AddRange(lnames);
            txtAuthorLname.MaskBox.AutoCompleteCustomSource = collection3;
            txtAuthorLname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuthorLname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void SendMessage()
        {
            MessageBox.Show("Success");
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            hm.TrimTextEdit(this);
            if (IsValid())
            {
                if (!db.IsDataExist("tblauthor", "fname='" + txtAuthorFname.Text + "' AND mname='" + txtAuthorMname.Text +
                            "' AND lname='" + txtAuthorLname.Text + "'"))
                {
                    db.InsertQuery("INSERT INTO tblauthor(fname,mname,lname) VALUES('" +
                        txtAuthorFname.Text + "','" + txtAuthorMname.Text + "','" + txtAuthorLname.Text + "');");
                    DataRow row = db.GetLastInsertItem("SELECT * FROM tblauthor ORDER BY authorID DESC LIMIT 1;");
                    if (row != null)
                    {
                        DataRow r = dt.NewRow();
                        r["authorID"] = row["authorID"].ToString();
                        r["fname"] = row["fname"].ToString();
                        r["mname"] = row["mname"].ToString();
                        r["lname"] = row["lname"].ToString();
                        r["isSelected"] = true;
                        dt.Rows.Add(r);
                        collection.Add(txtAuthorFname.Text);
                        collection2.Add(txtAuthorMname.Text);
                        collection3.Add(txtAuthorLname.Text);
                        hm.ClearTextEdit(this);
                    }
                }
                else
                {
                    db.UpdateListWithoutEditor("tblauthor WHERE corporation IS NULL", "authorID", new string[] { "authorID", "fname", "mname", "lname" }, dt);
                    List<DataRow> dr = dt.AsEnumerable().Where(s => s["fname"].ToString().ToLower().Equals(txtAuthorFname.Text.ToLower()) &&
                        s["mname"].ToString().ToLower().Equals(txtAuthorMname.Text.ToLower()) &&
                        s["lname"].ToString().ToLower().Equals(txtAuthorLname.Text.ToLower())).Select(s => s).ToList();
                    if (dr.Count > 0)
                        dr[0]["isSelected"] = true;
                    hm.ClearTextEdit(this);
                }
                db.UpdateListWithoutEditor("tblauthor WHERE corporation IS NULL", "authorID", new string[] { "authorID", "fname", "mname", "lname" }, dt);

            }
        }
        private bool IsValid()
        {
            if (!txtAuthorFname.Text.Equals("") && !txtAuthorLname.Text.Equals(""))
                return true;
            return false;
        }
        private bool IsUserExist()
        {
            IEnumerable<DataRow> table = from myRow in dt.AsEnumerable()
                                         where myRow.Field<string>("fname").ToLower().Equals(txtAuthorFname.Text.ToLower()) &&
                                             myRow.Field<string>("mname").ToLower().Equals(txtAuthorMname.Text.ToLower()) &&
                                             myRow.Field<string>("lname").ToLower().Equals(txtAuthorLname.Text.ToLower())
                                         select myRow;//linq to check if exist
            if (table != null) 
            {
                if (table.Count() != 0)
                {
                    dt.AsEnumerable().Where(s => s.Field<string>("fname").ToLower().Equals(txtAuthorFname.Text.ToLower()) &&
                        s.Field<string>("mname").ToLower().Equals(txtAuthorMname.Text.ToLower()) &&
                        s.Field<string>("lname").ToLower().Equals(txtAuthorLname.Text.ToLower())).Single().SetField<bool>("isSelected", true);
                    return true;
                }
            }
            return false;
        }
        public string[] GetSelectedAuthors()
        {
            List<string> selectedAuthors = new List<string>();
            foreach (DataRow r in dt.Rows)
            {
                string s = r["isSelected"].ToString();
                if (r["isSelected"].ToString().Equals("True"))
                    selectedAuthors.Add(r["authorID"].ToString());
            }
            return selectedAuthors.ToArray();
        }

        private void lstBookAuthorItem_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colIsSelected)
            {
                string id = lstBookAuthorItem.GetRowCellValue(e.RowHandle, colAuthorID).ToString();
                List<DataRow>dr = dt.AsEnumerable().Where(s => s["authorID"].ToString().Equals(id)).Select(s => s).ToList();
                if (dr.Count > 0)
                    dr[0]["isSelected"] = e.Value;
            }
        }

        private void txtAuthorLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            hm.TextHandle(ref sender, ref e, false);
        }


        //private void SetSelected()
        //{
        //    for (int i = 0; i < lstBookAuthorItem.RowCount; i++)
        //    {
        //        int rowHandle = lstBookAuthorItem.GetVisibleRowHandle(i);
        //        if(lstBookAuthorItem.IsDataRow(rowHandle))
        //        {
        //            object isSelected = lstBookAuthorItem.GetRowCellValue(rowHandle, lstBookAuthorItem.GetVisibleColumn(lstBookAuthorItem.Columns.Count));
        //            int val = Convert.ToInt32(isSelected);
        //            if (val == 1)
        //                lstBookAuthorItem.SelectRow(rowHandle);
        //            else
        //                lstBookAuthorItem.UnselectRow(rowHandle);
        //        }
        //    }
        //}

        
    }
}
