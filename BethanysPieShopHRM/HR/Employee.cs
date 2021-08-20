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
        private double? hourlyRate;// suffixing varibale with ? allows value to be null, useful for DB interactions where value may not be known
        private DateTime birthDay;
        
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

        public double? HourlyRate
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

        // Constructors
        public Employee(string first, string last, string em, DateTime bd, double? rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            BirthDay = bd;
            HourlyRate = rate ?? 10;// if value is null use value on right of ??
        }

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0) // calls the first constructor using 'this'
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
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value;// value used because HourlyRate could be null
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours worked is {Wage}.");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nBirthday: {BirthDay}\nTax Rate: {taxRate}\n");
        }

        public static void DisplayTaxRate()// static method can only use static data
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }

        public virtual void GiveBonus()// the virtual keyword allows for polymorphism on inherited classes
        {
            Console.WriteLine($"{FirstName} {LastName} recieves a generic bonus of $100!");
        }

    }
}
