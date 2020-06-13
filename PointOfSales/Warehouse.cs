﻿using System;
using System.Collections.Generic;

namespace PointOfSales
{
    public static class Warehouse
    {
        private static List<Item> _stockItem = new List<Item>();

        //public Warehouse()
        //{
        //    _stockItem 
        //}

        public static string RemoveItem(Item itm)
        {
            foreach (Item item in _stockItem)
            {
                if (item == itm)
                {
                    _stockItem.Remove(item);
                    return item.Name + "Has Removed";
                }

            }
            return "Item Not Found";
        }

        public static string ReduceItemStock(Item itm, int qty)
        {
            foreach(Item item in _stockItem)
            {
                if (item == itm)
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

        public static string FetchItemStock()
        {
            string result = "";
            foreach(Item item in _stockItem)
            {
                result += item.Name + item.Qty + Environment.NewLine;
            }
            return result;
        }
    }
}