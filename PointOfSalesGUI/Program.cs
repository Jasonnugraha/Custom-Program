using PointOfSales;
using PointOfSalesGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesGUI
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());

            dataSeed();

            
        }

        public static void dataSeed()
        {
            Item Sugar = new Item("sugar", "White Sugar", "A White Sugar", 10, 10);
            Warehouse.AddItem(Sugar);
        }
    }
}
