using System;
namespace PointOfSales
{
    public abstract class Payment
    {
        private int _paymentAmount;
        public Payment(int paymentAmount)
        {
            _paymentAmount = paymentAmount;
        }

    }
}
