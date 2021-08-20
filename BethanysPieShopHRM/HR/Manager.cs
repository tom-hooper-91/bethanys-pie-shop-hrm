using System;
namespace BethanysPieShopHRM.HR
{
    public class Manager : Employee
    {
        public Manager (string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)// base ivokes the base constructor Employee
        {
        }

        public void AttendManagementMeeting()// this method is not available in the Employee class
        {
            NumberOfHoursWorked += 10;// This property is available in this class as it is public
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email!");
        }

        public override void GiveBonus()// overide keyword allows for polymorphism
        {
            if (NumberOfHoursWorked > 5)
                Console.WriteLine($"{FirstName} {LastName} recieves a generic bonus of $500!");
            else
                Console.WriteLine($"{FirstName} {LastName} recieves a generic bonus of $250!");
        }
    }
}
