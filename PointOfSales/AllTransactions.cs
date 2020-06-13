using System;
using System.Collections.Generic;

namespace PointOfSales
{
    public static class AllTransactions
    {
        private static List<Transacation> _listTransactions = new List<Transacation>();
       
        public static void AddTransactions(Transacation transacation)
        {
            _listTransactions.Add(transacation);
        }

        public static List<Transacation> GetTransacations
        {
            get
            {
                return _listTransactions;
            }
        }
    }
}
