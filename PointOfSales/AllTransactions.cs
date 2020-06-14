using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PointOfSales
{
    public static class AllTransactions
    {
        private static BindingList<Transaction> _listTransactions = new BindingList<Transaction>();
       
        public static void AddTransactions(Transaction transaction)
        {
            _listTransactions.Add(transaction);
        }

        public static BindingList<Transaction> GetTransactions
        {
            get
            {
                return _listTransactions;
            }
        }
    }
}
