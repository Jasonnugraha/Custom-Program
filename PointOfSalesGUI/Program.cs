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
            dataSeed();

            Application.Run(new DashBoard());
            
        }

        public static void dataSeed()
        {
            Item Sugar = new Item("sugar", "White Sugar", "A White Sugar", 10, 10);
            Item Flour = new Item("flour", "White Flour", "A White Flour", 20, 5);
            Warehouse.AddItem(Sugar);
            Warehouse.AddItem(Flour);

            OnlineCustomer Jason = new OnlineCustomer("Jason","Hawthorn East","0477123456");
            Person Rifky = new OfflineCustomer("Rifky","Hawthorn East","0477123456");

            Customers.AddCustomer(Jason);
            Customers.AddCustomer(Rifky);

           

            Payment cash = new Cash(10000,10000);

            ShoppingCart cart = new ShoppingCart();
            cart.AddToCart("sugar");
            cart.AddToCart("flour");
            Jason.ShoppingCart = cart;


            Transaction newTransaction = new Transaction("ABC123", DateTime.Now, cash, Jason);

            AllTransactions.AddTransactions(newTransaction);

            foreach (Transaction transaction in AllTransactions.GetTransactions)
            {
                Console.WriteLine(transaction);
            }

            

        }
    }
}
