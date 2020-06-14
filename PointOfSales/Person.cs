using System;
namespace PointOfSales
{
    public abstract class Person
    {
        private ShoppingCart _shoppingCart;
        public Person(string name, string address, string phone, string id)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Type = id;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }

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
