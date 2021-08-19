using System;
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.DisplayTaxRate();// static method caled on the class not the object

            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------\n");

            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

            Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

            bethany.HourlyRate = 50; // use properties to update values
            bethany.NumberOfHoursWorked = 100;
            bethany.Wage = -10; // this will default to 0 when property is invoked

            #region First run Bethany

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.RecieveWage();

            #endregion

            #region First run George

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.RecieveWage();

            #endregion

            Customer customer = new Customer();

            Console.ReadLine();
        }
    }
}
