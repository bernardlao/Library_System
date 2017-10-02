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

namespace Library_System.Manage_Books
{
    public partial class Authors : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable table;
        public Authors(DataTable dt)
        {
            InitializeComponent();
            this.table = dt;
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            lstAuthors.DataSource = table;
        }
    }
}
