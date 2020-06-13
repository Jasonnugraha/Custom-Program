using System;
namespace PointOfSales
{
    public abstract class Transacation
    {
        private string _transactionId;
        private DateTime _transactionDate;

        public Transacation(string id, DateTime date)
        {
            _transactionDate = date;
            _transactionId = id;
        }

        public string TransacationId
        {
            get
            {
                return _transactionId;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _transactionDate;
            }
        }


    }
}
