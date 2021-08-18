using System;
namespace BethanysPieShopHRM
{
    public class Employee
    {
        // Fields
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthDay;

        public EmployeeType employeeType;

        //Constructors
        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            employeeType = empType;
            hourlyRate = rate;
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType) : this(first, last, em, bd, empType, 0) // calls the first constructor using 'this'
        {
        }

        //Methods
        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working");
        }

        public double RecieveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"The wage for {numberOfHoursWorked} is {wage}.");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {firstName}\nLast Name: {lastName}\nEmail: {email}\nBirthday: {birthDay}\nEmployee Type: {employeeType}\n");
        }

    }
}
