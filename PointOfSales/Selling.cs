using System;
using System.Collections.Generic;

namespace PointOfSales
{
    public class Selling : Transacation
    {
        private int _totalPrice;
        private Payment _payment;
        public Selling(string id, DateTime date) : base("sell", date)
        {

        }

        public void setPrice(ShoppingCart shoppingCart)
        {
            _totalPrice = shoppingCart.GetTotalPrice();
        }

        public int TotalPrice
        {
            get
            {
                return _totalPrice;
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
                _payment = new Cash();
            }
        }
    }
}
