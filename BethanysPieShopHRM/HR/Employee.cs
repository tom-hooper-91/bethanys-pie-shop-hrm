using System;
namespace BethanysPieShopHRM.HR
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

        public static double taxRate = 0.15;// static variable declared at class level
        public const double maxAmountOfHoursWorked = 1000;// constant variable that will never change, static by default

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
                if (value < 0)// validation logic for properties
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
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
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            EmployeeType = empType;
            HourlyRate = rate;
        }

        public Employee(string first, string last, string em, DateTime bd, EmployeeType empType) : this(first, last, em, bd, empType, 0) // calls the first constructor using 'this'
        {
        }

        // Methods
        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working");
        }

        public double RecieveWage()
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours worked is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay}\nEmployee Type: {EmployeeType}\nTax Rate: {taxRate}\n");
        }

        public static void DisplayTaxRate()// static method can only use static data
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

    }
}
