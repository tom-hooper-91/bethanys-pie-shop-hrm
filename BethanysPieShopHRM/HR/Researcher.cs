using System;
namespace BethanysPieShopHRM.HR
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public override double RecieveWage()
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

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            Console.WriteLine($"Researcher {FirstName} {LastName} has researched a new pie taste!");
        }

    }

    public class JuniorResearcher : Researcher// inheritance can go multiple layers deep
    {
        public JuniorResearcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

    }
}
