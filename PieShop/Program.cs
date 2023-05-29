using PieShop.HR;

public class Program
{
    public static void Main(string[] args)
    {
        //var bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", new DateTime(1993, 1, 16), 25);

        //bethany.DisplayEmployeeDetails();

        //bethany.PerformWork();
        //bethany.PerformWork();
        //bethany.PerformWork(5);
        //bethany.PerformWork();
        //bethany.PerformWork();

        //double recivedWageBethany = bethany.ReviceWage(true);
        //System.Console.WriteLine($"Wage paid (message from Program): {recivedWageBethany}");

        #region Run George

        //Employee george = new("George", "Jones", "george@pcr.ge", new DateTime(1990, 11, 15), 30);

        ////george.PerformWork();
        ////george.PerformWork();
        ////george.PerformWork(8);
        ////george.PerformWork();

        //double recievedWageGeorge = george.ReviceWage();

        //george.DisplayEmployeeDetails();

        //System.Console.WriteLine($"Wage paid (message from Program): {recievedWageGeorge}");

        #endregion

        IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);
        IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);
        IEmployee mary = new Manager("Mary", "Jones", "mary@gmail.com", new DateTime(1979, 2, 24), 30);
        IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@gmail.com", new DateTime(1998, 1, 23), 17);
        IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@gmail.com", new DateTime(1979, 1, 16), 25);

        List<IEmployee> employees = new List<IEmployee>
        {
            bethany,
            mary,
            bobJunior,
            kevin,
            kate
        };

        foreach (Employee employee in employees)
        {
            employee.DisplayEmployeeDetails();
            employee.GiveBonus();
        }

        //Employee lasha = new StoreManager("Lasha", "Oniani", "oniani@gmail.com", new DateTime(2000, 03, 29), 25);



        //Employee sergo = new("Sergo", "Kobaladze", "sk@yahoo.ge", new DateTime(2000, 08, 17), 30);

        //string sergoToJson = sergo.ConvertToJson();
        //Console.WriteLine(sergoToJson);

        //sergo.PerformWork();
        //sergo.PerformWork();
        //sergo.PerformWork(28);
        //sergo.PerformWork();

        //int minimumBonus = 100;
        //int bonusTax = 0;
        //int recivedBonus = sergo.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);

        //sergo.DisplayEmployeeDetails();
        //bobJunior.DisplayEmployeeDetails();
        //bobJunior.ResearchNewPieTastes(5);
        //bobJunior.ResearchNewPieTastes(5);
        //mary.DisplayEmployeeDetails();
        //mary.PerformWork(25);
        //mary.PerformWork();
        //mary.PerformWork();
        //mary.ReviceWage();
        //mary.AttandManagmentMeeting();

        //mary.GiveBonus();

        //System.Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {sergo.FirstName} has recieved a bonus of {recivedBonus}\n");

        //string name = "sergo";
        //string anotherName = name;
        //name += " Kobaladze";

        //System.Console.WriteLine("Name: " + name.ToUpper());
        //System.Console.WriteLine("Another Name: " + anotherName.ToUpper());

        //WorkTask task;
        //task.description = "Baking delicious pies";
        //task.hours = 3;
        //task.PerformWorkTask();

        //Console.WriteLine("How many employees ID you want to register?");
        //int input = Convert.ToInt32(Console.ReadLine());

        //int[] arr = new int[input];
        //var testId = arr[0];

        //for (int i = 0; i < input; i++)
        //{
        //    Console.WriteLine("Enter employee ID: ");
        //    int id = int.Parse(Console.ReadLine()!);

        //    arr[i] = id;
        //}

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"ID {i + 1}: \t{arr[i]}");
        //}

        //Array.Sort(arr);

        //Console.WriteLine("\nAfter Sorting: ");
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"ID {i + 1}: \t{arr[i]}");
        //}

        //int[] arrCopy = new int[input];
        //arr.CopyTo(arrCopy, 0);

        //Array.Reverse(arr);

        //Console.WriteLine("After reverse the Array");

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine($"ID {i + 1}: \t{arr[i]}");
        //}

        //Console.WriteLine("Copy of Array");

        //for (int i = 0; i < arrCopy.Length; i++)
        //{
        //    Console.WriteLine($"ID {i + 1}: \t{arrCopy[i]}");
        //}
    }
}