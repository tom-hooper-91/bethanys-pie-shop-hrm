using System;
namespace BethanysPieShopHRM.Accounting
{
    public class Customer
    {
        // Fields
        private string customerID;
        private string name;

        // Properties
        public string CustomerID
        {
            get { return customerID; }
            set
            {
                customerID = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
    }
}
