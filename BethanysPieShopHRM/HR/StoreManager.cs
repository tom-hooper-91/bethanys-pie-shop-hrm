using System;
namespace BethanysPieShopHRM.HR
{
    public class StoreManager : Employee
    {
        public StoreManager(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }
    }
}
