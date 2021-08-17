using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int monthsWorked = 12;
            int bonus = 1000;

            int yearlyWage = CalculateYearlyWage(monthlyWage, monthsWorked);

            Console.WriteLine($"Yearly Wage is : ${yearlyWage}");

            double monthlyWageDouble = 1234.0;
            double monthsWorkedDouble = 12.0;
            double bonusDouble = 1000.0;

            double yearlyWageDouble = CalculateYearlyWage(monthlyWageDouble, monthsWorkedDouble, bonusDouble);

            Console.ReadLine();
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1); // Add's a bonus month if they have worked all year
            }

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            Console.WriteLine($"The Yearly Wage is : ${monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"The Yearly Wage is : ${monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
