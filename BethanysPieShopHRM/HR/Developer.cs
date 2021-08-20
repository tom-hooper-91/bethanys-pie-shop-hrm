using System;
namespace BethanysPieShopHRM.HR
{
    public sealed class Developer : Employee// sealed keyword stops any class from deriving from Developer
    {
        public Developer(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }
    }

    //public class JuniorDeveloper : Developer ----- this is not possible due to use of sealed keywords
    //{

    //}
}
