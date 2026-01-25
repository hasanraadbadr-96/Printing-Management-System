using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Orders.From
{
    public partial class frmShowOrderDetials : Form
    {
        int _OrderID = -1;
        public frmShowOrderDetials(int OrderID)
        {
            InitializeComponent();
            _OrderID = OrderID;
        }

        private void frmShowOrderDetials_Load(object sender, EventArgs e)
        {
            ctrlOrderCard1.LoadOrderInfo(_OrderID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
