using System;
namespace PointOfSales
{
    public class Card : Payment
    {
        private string _cardnumber;
        private DateTime _expired;
        public Card(int paymentAmount,string cardnumber,DateTime dateTime) : base(paymentAmount)
        {
            _cardnumber = cardnumber;
            _expired = dateTime;
        }
    }
}
