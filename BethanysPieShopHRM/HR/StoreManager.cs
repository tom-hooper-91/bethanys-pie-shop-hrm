using System;
namespace BethanysPieShopHRM.HR
{
    public class StoreManager : Employee
    {
        public StoreManager(int id, string first, string last, string em, DateTime bd, double? rate) : base(id, first, last, em, bd, rate)
        {
        }

        //public override double RecieveWage() ----- here from when Employee method was abstract
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
}
