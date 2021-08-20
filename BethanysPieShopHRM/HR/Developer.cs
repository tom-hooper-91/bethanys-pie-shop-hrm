using System;
namespace BethanysPieShopHRM.HR
{
    public sealed class Developer : Employee// sealed keyword stops any class from deriving from Developer
    {
        public Developer(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public override double RecieveWage()// must define RecieveWage method or class will become abstract
        {
            {
                double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;// value used because HourlyRate could be null
                double taxAmount = wageBeforeTax * taxRate;

                Wage = wageBeforeTax - taxAmount;

                Console.WriteLine($"The wage for {NumberOfHoursWorked} hours worked is {Wage}.");
                NumberOfHoursWorked = 0;

                return Wage;
            }
        }
    }

    //public class JuniorDeveloper : Developer ----- this is not possible due to use of sealed keywords
    //{

    //}
}
