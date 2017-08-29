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
        private MySQLDBUtilities db = new MySQLDBUtilities();
        List<int> checkIndexes = new List<int>();
        DataTable dt = new DataTable();
        public addBookAuthor()
        {
            InitializeComponent();
        }

        private void addBookAuthor_Load(object sender, EventArgs e)
        {
            dt = db.SelectTable("SELECT authorID,fname,mname,lname FROM tblauthor");
            SetAutoComplete(dt);
            lstBookAuthor.DataSource = dt;
            IEnumerable<DataRow> table = from myRow in dt.AsEnumerable()
                                         where myRow.Field<string>("fname").ToLower().Equals(txtAuthorFname.Text.ToLower()) &&
                                             myRow.Field<string>("mname").ToLower().Equals(txtAuthorMname.Text.ToLower()) &&
                                             myRow.Field<string>("lname").ToLower().Equals(txtAuthorLname.Text.ToLower())
                                         select myRow;//linq to check if exist
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
            collection = new AutoCompleteStringCollection();
            collection.AddRange(mnames);
            txtAuthorMname.MaskBox.AutoCompleteCustomSource = collection;
            txtAuthorMname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuthorMname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            collection = new AutoCompleteStringCollection();
            collection.AddRange(lnames);
            txtAuthorLname.MaskBox.AutoCompleteCustomSource = collection;
            txtAuthorLname.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAuthorLname.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        public void SendMessage()
        {
            MessageBox.Show("Success");
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                DataRow r = dt.NewRow();
                r["authorID"] = -1;
                r["fname"] = txtAuthorFname.Text;
                r["mname"] = txtAuthorMname.Text;
                r["lname"] = txtAuthorLname.Text;

                dt.Rows.Add(r);
            }
        }
        private bool IsValid()
        {
            if (!txtAuthorFname.Text.Equals("") && !txtAuthorLname.Text.Equals(""))
                return true;
            return false;
        }
    }
}
