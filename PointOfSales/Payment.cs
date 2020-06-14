using System;
namespace PointOfSales
{
    public abstract class Payment
    {
        private int _paymentAmount;
        private string _paymentType;
        public Payment(int paymentAmount,string paymentType)
        {
            _paymentAmount = paymentAmount;
            _paymentType = paymentType;
        }

        public int PaymentAmount
        {
            get
            {
                return _paymentAmount;
            }
            set
            {
                _paymentAmount = value;
            }
        }

        public string PaymentType
        {
            get
            {
                return _paymentType;
            }
            set
            {
                _paymentType = value;
            }
        }


    }
}
