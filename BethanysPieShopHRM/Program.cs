using System;
using System.Collections.Generic;
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

            Manager bethany = new Manager(776, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            StoreManager kevin = new StoreManager(1842, "Kevin", "Allan", "kevin@snowball.bn", new DateTime(1970, 4, 30), 35);
            Developer tom = new Developer(33389, "Tom", "Hooper", "tom@hotmail.com", new DateTime(1991, 10, 30), 30);
            Manager mary = new Manager(3547, "Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
            JuniorResearcher bobJunior = new JuniorResearcher(101, "Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

            //Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

            //bethany.HourlyRate = 50; // use properties to update values
            //bethany.NumberOfHoursWorked = 100;
            //bethany.Wage = -10; // this will default to 0 when property is invoked

            //bethany.DisplayEmployeeDetails();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.PerformWork();
            //bethany.RecieveWage();

            //mary.DisplayEmployeeDetails();
            //mary.AttendManagementMeeting();


            //bobJunior.ResearchNewPieTastes(10);
            //bobJunior.RecieveWage();

            //bethany.GiveBonus();
            //mary.GiveBonus();
            //tom.GiveBonus();

            //Employee[] employees = new Employee[5];// can use the base type Employee to create array that can use polymorphism
            //employees[0] = bethany;
            //employees[1] = kevin;
            //employees[2] = tom;
            //employees[3] = mary;
            //employees[4] = bobJunior;

            //foreach (var employee in employees)
            //{
            //    employee.PerformWork();
            //    employee.RecieveWage();
            //    employee.DisplayEmployeeDetails();
            //    employee.GiveBonus();// this method will call the most specific method to the class, manager bonus will use override method
            //    //employee.AttendManagementMeeting(); cannot call this method through an Employee reference

            //    Console.WriteLine(employee.ToString());// this is inherited from System.Object

            //    object o1 = new Manager(89700, "Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
            //    o1.ToString();// this only has access to base object functionality
            //}

            List<Employee> employees = new List<Employee>();
            employees.Add(bethany);
            employees.Add(kevin);
            employees.Add(mary);
            employees.Add(tom);
            employees.Add(bobJunior);

            employees.Sort();// this is doable because of the IComparable interface and invokes the CompareTo method

            foreach (var employee in employees)
            {
                employee.DisplayEmployeeDetails();
            }

            Console.ReadLine();
        }
    }
}
