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
        private MySQLDBUtilities db = new MySQLDBUtilities();
        private HelperMethods hm = new HelperMethods();
        GridControl gc;
        SplitContainerControl scc;
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
    }
}
