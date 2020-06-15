using System;
using System.Collections.Generic;

namespace PointOfSales
{
    public class Transaction
    {
        private string _id;
        private int _totalPrice;
        private Payment _payment;
        private Person _person;
        private DateTime _transactionDate;
        public Transaction(string id, DateTime date, Payment payment, Person person)
        {
            _id = id;
            _totalPrice = setPrice(person);
            _payment = payment;
            _person = person;
            _transactionDate = date;
        }

        public int setPrice(Person person)
        {
            return person.ShoppingCart.GetTotalPrice();
        }

        

        public string TransactionId
        {
            get
            {
                return _id;
            }
        }

        public string CustomerName
        {
            get
            {
                return _person.Name;
            }
        }

        public DateTime TransactionDate
        {
            get
            {
                return _transactionDate;
            }
        }

        public string CustomerType
        {
            get
            {
                return _person.Type;
            }
        }

        public string Payment_Type
        {
            get
            {
                return _payment.PaymentType;
            }
            set
            {
                _payment.PaymentType = value;
            }
        }

        public void setPayment(string payment, DateTime expired, string cardnumber)
        {
            if(payment == "card")
            {
                _payment = new Card(_totalPrice,cardnumber, expired);
            }
            else
            {
                //_payment = new Cash();
            }
        }
    }
}
