namespace PieShop.HR
{
    public class Researcher : Employee
    {
        public Researcher(
            string firstName,
            string lastName,
            string email,
            DateTime birthDay,
            double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }

        private int numbersOfPieTastesInvented = 0;

        public int NumbersOfPieTastesInvented
        {
            get { return numbersOfPieTastesInvented; }
            private set => numbersOfPieTastesInvented = value;
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumbersOfHoursWorked += researchHours;

            if (new Random().Next(100) >  50)
            {
                NumbersOfPieTastesInvented++;

                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste! Total number of pies invented: {NumbersOfPieTastesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is working still on a new pie taste");
            }
        }
    }
}
