using System;
namespace BethanysPieShopHRM.HR
{
    public interface IEmployee// interface is similar to abstract class but can have multiple inheritance
    {
        double RecieveWage();

        void GiveBonus();

        void PerformWork();

        void StopWorking();

        void DisplayEmployeeDetails();
    }
}
