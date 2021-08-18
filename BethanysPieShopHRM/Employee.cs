using System;
namespace BethanysPieShopHRM
{
    public class Employee
    {
        // Fields
        private string firstName;
        private string lastName;
        private string email;
        
        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthDay;
        
        private EmployeeType employeeType;

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;// value is a keyword that is built into properties
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                wage = value;
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }

        public EmployeeType EmployeeType
        {
            get
            {
                return employeeType;
            }
            set
            {
                employeeType = value;
            }
        }

        // Constructors
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

        // Methods
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
