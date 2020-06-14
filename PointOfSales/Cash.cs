using System;
namespace PointOfSales
{
    public class Cash : Payment
    {
        private int _change;
        public Cash(int payment):base(payment,"cash")
        {

        }

    }
}
