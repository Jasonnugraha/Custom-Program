using System;
using System.Collections.Generic;
namespace PointOfSales
{
    public class ShoppingCart
    {
        private int _totalPrice;
        private List<Item> _shoppingList;
        public ShoppingCart()
        {
            _shoppingList = new List<Item>();
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

        public List<Item> ShoppingList
        {
            get
            {
                return _shoppingList;
            }
        }

        public int GetTotalPrice()
        {
            int result = 0;
            foreach(Item item in _shoppingList)
            {
                result += (item.Qty * item.Price);
            }
            return result;
        }
    }
}
