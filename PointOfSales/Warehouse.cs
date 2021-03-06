﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PointOfSales
{
    public static class Warehouse
    {
        private static BindingList<Item> _stockItem = new BindingList<Item>();

        public static string RemoveItem(string itm)
        {
            foreach (Item item in _stockItem)
            {
                if (item.Id == itm)
                {
                    _stockItem.Remove(item);
                    return item.Name + "Has Removed";
                }

            }
            return "Item Not Found";
        }

        public static string ReduceItemStock(string itm, int qty)
        {
            foreach(Item item in _stockItem)
            {
                if (item.Id == itm)
                {
                    if(item.Qty >= qty)
                    {
                        int tempStock = item.Qty;
                        item.Qty -= qty;
                        return item.Name + " has reduced from " + tempStock + " and now is " + item.Qty;
                    }
                    else
                    {
                        return item.Name + " only has " + item.Qty + "left";
                    }
                }
            }
            return "Item not found";
        }

        public static Item FetchItem(string itm)
        {
            foreach(Item item in _stockItem)
            {
                if (item.Id == itm)
                {
                    return item;
                }
            }
            return null;
        }

        public static Item FetchAnItem(string itm)
        {
            foreach (Item item in _stockItem)
            {
                if (item.Id == itm)
                {
                    return item;
                }
            }
            return null;
        }

        public static void AddItem(Item item)
        {
            _stockItem.Add(item);
        }

        public static BindingList<Item> Stocks
        {
            get
            {
                return _stockItem;
            }
        }
    }
}
