using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PointOfSales
{
    public static class Customers
    {
        private static BindingList<Person> _listOfCustomers = new BindingList<Person>();

        public static void AddCustomer(Person person)
        {
            _listOfCustomers.Add(person);
        }

        public static void RemoveCustomer(Person person)
        {
            _listOfCustomers.Remove(person);
        }

        public static BindingList<Person> GetCustomers
        {
            get
            {
                return _listOfCustomers;
            }
        }
    }
}
