using System;
using System.Collections.Generic;
namespace PointOfSales
{
    public class Buying:Transacation
    {
        private List<Supplier> _suppliers;

        public Buying(string id, DateTime date) : base(id, date)
        {
            _suppliers = new List<Supplier>();

        }


    }
}
