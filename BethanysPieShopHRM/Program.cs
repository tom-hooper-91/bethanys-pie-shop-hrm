using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int monthsWorked = 12;

            int yearlyWage = CalculateYearlyWage(monthlyWage, monthsWorked);

            Console.WriteLine($"Yearly Wage is : ${yearlyWage}");

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
    }
}
