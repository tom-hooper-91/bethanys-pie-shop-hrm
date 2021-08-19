using System;
namespace BethanysPieShopHRM.HR
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
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
