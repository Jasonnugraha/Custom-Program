using System;
using System.Collections.Generic;

namespace PointOfSales
{
    public static class Customers
    {
        private static List<Person> _listOfCustomers = new List<Person>();

        public static void AddCustomer(Person person)
        {
            _listOfCustomers.Add(person);
        }

        public static void RemoveCustomer(Person person)
        {
            _listOfCustomers.Remove(person);
        }

        public static List<Person> GetCustomers
        {
            get
            {
                return _listOfCustomers;
            }
        }
    }
}
