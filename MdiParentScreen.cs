using ETEZAN2024.forms.frmMainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024
{
    public partial class MdiParentScreen : Form
    {
        private frmLoginUser  frmLoginUser = new frmLoginUser();
      
        public MdiParentScreen()
        {
            InitializeComponent();
        }

        private void MdiParentScreen_Load(object sender, EventArgs e)
        {
            frmLoginUser.MdiParent =this;
            frmLoginUser.Show();
    
    }
}
}
