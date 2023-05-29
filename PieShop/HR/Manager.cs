namespace PieShop.HR
{
    public class Manager : Employee
    {
        public Manager(
            string firstName,
            string lastName,
            string email,
            DateTime birthDay,
            double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        public void AttandManagmentMeeting()
        {
            NumbersOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a long meeting that could have been an email!");
        }

        public override void GiveBonus()
        {
            if (NumbersOfHoursWorked > 5)
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recieved a management bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} recieved a management bonus of 250!");
            }
        }
    }
}
