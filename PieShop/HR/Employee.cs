using Newtonsoft.Json;

namespace PieShop.HR
{
    public class Employee: IEmployee
    {
        private string? firstName;
        private string? lastName;
        private string? email;

        private int numbersOfHoursWorked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;
        private const int minimalHoursWorkedUnit = 1;

        private Address address;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get
            {
                return firstName!;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName!;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get { return email!; }
            set => email = value;
        }

        public int NumbersOfHoursWorked
        {
            get { return numbersOfHoursWorked; }
            protected set
            {
                numbersOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            private set
            {
                wage = value;
            }
        }

        public double? HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
            set => birthDay = value; 
        }

        public Address Address
        { 
            get { return address; } 
            set => address = value;
        }

        public Employee(
           string firstName,
           string lastName,
           string employee,
           DateTime birthDay) : this(firstName, lastName, employee, birthDay, 0)
        {

        }

        public Employee(
            string firstName,
            string lastName,
            string email,
            DateTime birthDay,
            double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
        }
        
        public Employee(
            string firstName,
            string lastName,
            string email,
            DateTime birthDay,
            double? hourlyRate,
            string street,
            string houseNumber,
            string zip,
            string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numbersOfHours)
        {
            NumbersOfHoursWorked += numbersOfHours;

            System.Console.WriteLine($"{FirstName} {LastName} has worked for" +
                $" {numbersOfHours} hour(s)!");
        }

        public double RecieveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumbersOfHoursWorked * HourlyRate!.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"\n{FirstName} {LastName} has recived a wage of {Wage}" +
                $" for {NumbersOfHoursWorked} hour(s) of work!");

            if (resetHours)
            {
                NumbersOfHoursWorked = 0;
            }

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            System.Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: " +
                $"{LastName}\nEmail: {Email}\nBirthday: {BirthDay.ToShortDateString()}\n");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumbersOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            System.Console.WriteLine($"\nThe employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (NumbersOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            System.Console.WriteLine($"\nThe employee got a bonus of {bonus}" +
                $" and the Tax on the bonus is {bonusTax}");
            return bonus;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} recieved a generic bonus of 100");
        }
    }
}