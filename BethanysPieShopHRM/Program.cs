using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            int bonus = 1000;

            bool isActive = true;
            double rating = 99.25;

            double ratePerHour = 12.34;
            int numberOfHourWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHourWorked + bonus;

            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);

            DateTime hireDate = new DateTime(2021, 3, 28, 14, 30, 0);

            Console.WriteLine(hireDate);

            // DateTime exitDate = new DateTime(2021, 15, 11);

            DateTime startDate = hireDate.AddDays(15);

            DateTime currentDate = DateTime.Now;
            bool areWeInDst = currentDate.IsDaylightSavingTime();

            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine(startHour.ToLongDateString());
            Console.WriteLine(endHour.ToShortTimeString());


            Console.ReadLine();
        }
    }
}
