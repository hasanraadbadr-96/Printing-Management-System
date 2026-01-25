using BusinessLayeres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Products.controls
{
    public partial class ctrlProductCard : UserControl
    {
        private int _ProductID =-1;
        private clsProducts _Product;
        public int ProductID
        {
            get { return _ProductID; }
        }
        public clsProducts ProductInfo
        {
            get { return _Product; }
        }
        public ctrlProductCard()
        {
            InitializeComponent();
        }

        private void _ResetDefualtValues()
        {
            lbProductID.Text = "####";
            lbProdectName.Text = "####";
            lbtbProduct_type.Text = "####";
            lbSize.Text = "####";
            lbWeight.Text = "####";
        }
        private void _FillProductInfo()
        {
            lbProductID.Text = _Product.productID.ToString();
            lbProdectName.Text = _Product.productName;
            lbtbProduct_type.Text = _Product.productType.ToString();
            lbSize.Text = _Product.Size;
            lbWeight.Text = _Product.Weight;
            lbQuantity.Text = _Product.Quantity.ToString();
            lbwastage_percentage.Text = _Product.wastagePercentage.ToString() +" % ";


        }
        public void LoadProductInfo(int productID)
        {
            _ProductID=productID;
            _Product = clsProducts.FindProduct(productID);
            if (_Product == null) // اذا رجع منتج
            {
                _ResetDefualtValues(); // نفرغ القيم (هنا خطأ منطقي المفروض العكس)
                MessageBox.Show("لم يتم العثور علئ هذا المنتج", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error); // رسالة خطأ
                return; // نطلع
            }

            _FillProductInfo();
        }
        private void ctrlProductCard_Load(object sender, EventArgs e)
        {

        }

        private void lnkEditProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEidtProduct eidtProduct = new frmAddAndEidtProduct(_ProductID);
            eidtProduct.ShowDialog();
            LoadProductInfo(_ProductID);
        }
    }
}
