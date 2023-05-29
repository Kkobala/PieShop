namespace PieShop.HR
{
    public class Developer : Employee
    {
        private string? currenctProject;

        public string? CurrentProject
        {
            get { return currenctProject; }
            set => currenctProject = value;
        }

        public Developer(
            string firstName, 
            string lastName,
            string email, 
            DateTime birthDay, 
            double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
        {
        }
    }
}
