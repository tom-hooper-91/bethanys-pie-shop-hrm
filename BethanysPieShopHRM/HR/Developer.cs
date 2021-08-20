using System;
namespace BethanysPieShopHRM.HR
{
    public sealed class Developer : Employee// sealed keyword stops any class from deriving from Developer
    {
        public Developer(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {
        }

        //public override double RecieveWage()// ----- here from when Employee method was abstract
        //{
        //    {
        //        double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;// value used because HourlyRate could be null
        //        double taxAmount = wageBeforeTax * taxRate;

        //        Wage = wageBeforeTax - taxAmount;

        //        Console.WriteLine($"The wage for {NumberOfHoursWorked} hours worked is {Wage}.");
        //        NumberOfHoursWorked = 0;

        //        return Wage;
        //    }
        //}
    }

    //public class JuniorDeveloper : Developer ----- this is not possible due to use of sealed keywords
    //{

    //}
}
