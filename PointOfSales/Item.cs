using System;
namespace PointOfSales
{
    public class Item
    {
        public Item(string id, string name, string desc, int qty, int price)
        {
            Id = id;
            Name = name;
            Desc = desc;
            Qty = qty;
            Price = price;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }


    }
}
