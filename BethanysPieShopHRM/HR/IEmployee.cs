using System;
namespace BethanysPieShopHRM.HR
{
    public interface IEmployee// interface is similar to abstract class but can have multiple inheritance
    {
        double ReceiveWage();

        void GiveBonus();

        void PerformWork();

        void StopWorking();

        void DisplayEmployeeDetails();
    }
}
