using ETEZAN2024.forms_And_Contrls.Persons.Control;
using ETEZAN2024.forms_And_Contrls.Users.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Users.form
{
    public partial class frmUserInfo : Form
    {
        private int _UserID;
      //  ctrlUserCard ctrlUserCard1 = new ctrlUserCard(); // إنشاؤه
        public frmUserInfo(int userID)
        {
            InitializeComponent();
            _UserID = userID;

         
        }

        private void frmFindUser_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
