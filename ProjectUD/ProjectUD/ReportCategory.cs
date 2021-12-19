using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUD
{
    public partial class ReportCategory : Form
    {
        public ReportCategory()
        {
            InitializeComponent();
        }

        private void ReportCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLCPDataSet.FOODCATEGORY' table. You can move, or remove it, as needed.
            this.FOODCATEGORYTableAdapter.Fill(this.QLCPDataSet.FOODCATEGORY);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
