namespace PieShop.HR
{
    public interface IEmployee
    {
        double RecieveWage(bool resetHours = true);
        void GiveBonus();
        void PerformWork();
        void PerformWork(int numberOfHours);
        void DisplayEmployeeDetails();
    }
}
