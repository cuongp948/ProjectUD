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
    public partial class ReportFoodPrice : Form
    {
        public ReportFoodPrice()
        {
            InitializeComponent();
        }

        private void ReportFoodPrice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'showfoodprice.PS_SHOWFOODPRICE' table. You can move, or remove it, as needed.
          
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            int price = int.Parse(txtprice.Text);
            this.PS_SHOWFOODPRICETableAdapter.Fill(this.showfoodprice.PS_SHOWFOODPRICE,price);

            this.reportViewer1.RefreshReport();
        }
    }
}
