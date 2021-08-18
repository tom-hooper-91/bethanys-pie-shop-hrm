using System;

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingEnumerations();

            UsingStruct();

            Console.ReadLine();

        }

        private static void UsingStruct()
        {
            Employee employee;
            employee.Name = "Bethany";
            employee.Wage = 1250;
            employee.Work();
        } 

        struct Employee
        {
            public string Name;
            public int Wage;

            public void Work()
            {
                Console.WriteLine($"{Name} is doing some work");
            }
        }


        private static void UsingEnumerations()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;

            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculatedWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculatedWage = baseWage * 3;
            }
            else
            {
                calculatedWage *= 2;
            }

            if (storeType == StoreType.FullPieResteraunt)
            {
                calculatedWage += 500;
            }

            Console.WriteLine($"Calculate Wage is : ${calculatedWage}");
        }

        enum EmployeeType
        {
            Sales,// 0
            Manager,// 1
            Research,// 2
            StoreManager// 3
        }

        enum StoreType
        {
            PieCorner = 10,
            Seating = 20,
            FullPieResteraunt = 100,
            Undefined = 99
        }
    }
}
