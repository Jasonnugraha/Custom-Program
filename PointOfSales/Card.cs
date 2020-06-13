using System;
namespace PointOfSales
{
    public class Card:Payment
    {
        private string _cardnumber;
        private DateTime _expired;
        public Card(string cardnumber,DateTime dateTime)
        {
            _cardnumber = cardnumber;
            _expired = dateTime;
        }
    }
}
