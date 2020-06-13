using System;
namespace PointOfSales
{
    public class OnlineCustomer : Person
    {
        private DateTime _estimatedTime;

        public OnlineCustomer(string name, string address, string phone) : base(name, address, phone)
        {
            
        }

        public DateTime EstimatedTime
        {
            get
            {
                return _estimatedTime;
            }
            set
            {
                _estimatedTime = value;
            }
        }
    }
}
