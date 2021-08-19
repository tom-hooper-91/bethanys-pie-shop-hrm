using System;
namespace BethanysPieShopHRM.HR
{
    public class Developer : Employee
    {
        public Developer(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }
    }
}
