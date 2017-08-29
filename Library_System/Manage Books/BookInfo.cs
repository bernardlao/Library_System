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

namespace Library_System
{
    public partial class addBookInfo : DevExpress.XtraEditors.XtraUserControl
    {
        GridControl gc;
        SplitContainerControl scc;
        public addBookInfo()
        {
            InitializeComponent();
            
        }

        private void optPerson_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
