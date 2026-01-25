using ETEZAN2024.forms.frmMainMenu;
using ETEZAN2024.forms.Persons;
using ETEZAN2024.forms_And_Contrls.CashBoxs;
using ETEZAN2024.forms_And_Contrls.Debts;
using ETEZAN2024.forms_And_Contrls.Inventories;
using ETEZAN2024.forms_And_Contrls.OrderCashBoxsDistribution;
using ETEZAN2024.forms_And_Contrls.Orders;
using ETEZAN2024.forms_And_Contrls.Persons.form;
using ETEZAN2024.forms_And_Contrls.PricesProduct;
using ETEZAN2024.forms_And_Contrls.ProductPrices;
using ETEZAN2024.forms_And_Contrls.Products;
using ETEZAN2024.forms_And_Contrls.Users;
using ETEZAN2024.forms_And_Contrls.Users.form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETEZAN2024
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new frmLoginUser());
            //Application.Run(new frmOrderCashBoxsDistributionList());

           // Application.Run(new frmAddAndEditDebt());

        }
    }
}
