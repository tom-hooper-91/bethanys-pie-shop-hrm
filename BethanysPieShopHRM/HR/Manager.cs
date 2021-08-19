using System;
namespace BethanysPieShopHRM.HR
{
    public class Manager : Employee
    {
        public Manager (string first, string last, string em, DateTime bd, double? rate):base(first, last, em, bd, rate)// base ivokes the base constructor Employee
        {

        }
    }
}
