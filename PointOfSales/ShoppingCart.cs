using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PointOfSales
{
    public class ShoppingCart
    {
        private int _totalPrice;
        private BindingList<Item> _shoppingList;
        public ShoppingCart()
        {
            _shoppingList = new BindingList<Item>();
        }

        public void AddToCart(string id)
        {
            _shoppingList.Add(Warehouse.FetchItem(id));
        }

        public string RemoveItem(string id)
        {
            foreach (Item item in _shoppingList)
            {
                if (item.Id == id)
                {
                    _shoppingList.Remove(item);
                    return item.Name + " has removed";
                }
            }
            return "Item is not found";
        }

        public void AddCopy(Item item)
        {
            _shoppingList.Add(item);
        }

        public BindingList<Item> ShoppingList
        {
            get
            {
                return _shoppingList;
            }
        }



        public int GetTotalPrice()
        {
            foreach (Item item in _shoppingList)
            {
                _totalPrice += (item.Qty * item.Price);
            }
            return _totalPrice;
        }

        public ShoppingCart shoppingCart
        {
            get
            {
                return this;
            }

        }

    }
}
