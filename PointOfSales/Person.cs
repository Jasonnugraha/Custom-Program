using System;
namespace PointOfSales
{
    public abstract class Person
    {
        public Person(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
