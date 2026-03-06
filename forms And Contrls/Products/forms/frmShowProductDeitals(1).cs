using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Products.forms
{
    public partial class frmShowProductDeitals : Form
    {
        int _ProductID = -1;
        public frmShowProductDeitals(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }

        private void frmShowProductDeitals_Load(object sender, EventArgs e)
        {
            ctrlProductCard1.LoadProductInfo(_ProductID);
        }
    }
}
