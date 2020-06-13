using System;
namespace PointOfSales
{
    public abstract class Person
    {
        public Person(string name, string address, string phone, string id)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Id = id;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Id { get; set; }
    }
}
