using System;
using System.Collections.Generic;
namespace PointOfSales
{
    public class Buying:Transacation
    {
        public Buying(string id, DateTime date) : base("buy", date)
        {

        }

    }
}

