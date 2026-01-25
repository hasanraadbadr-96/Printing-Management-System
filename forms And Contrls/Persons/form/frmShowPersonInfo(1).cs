using ETEZAN2024.forms_And_Contrls.Persons.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024.forms_And_Contrls.Persons.form
{
    public partial class frmShowPersonInfo : Form
    {
        private ctrlPersonCard _ctrlPersonCard;
        private  int _personID;

        public frmShowPersonInfo(int personid)
        {
            InitializeComponent();
            _personID = personid;

            _ctrlPersonCard = new ctrlPersonCard(); // إنشاؤه
            _ctrlPersonCard.Dock = DockStyle.Bottom; // حتى ياخذ حجم الفورم
            this.Controls.Add(_ctrlPersonCard);    // إضافته للفورم
        }

        private void _LoadData(int personID )
        {
            _ctrlPersonCard.LoadPersonInfoByID(personID);
        }
        private void frmPersonCard_Load(object sender, EventArgs e)
        {
            _LoadData(_personID);
        }
    }
}
