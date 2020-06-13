using System;
namespace PointOfSales
{
    public class OnlineCustomer : Person
    {
        private DateTime _estimatedTime;
        private ShoppingCart _shoppingCart;

        public OnlineCustomer(string name, string address, string phone) : base(name, address, phone, "online")
        {

        }

        public DateTime EstimatedTime
        {
            get
            {
                return _estimatedTime;
            }
            set
            {
                _estimatedTime = value;
            }
        }

        public ShoppingCart ShoppingCart
        {
            get
            {
                return _shoppingCart;
            }
            set
            {
                _shoppingCart = value;
            }
        }
    }
}
