public class Employee
{
    public string FirstName;
    public string LastName;
    public string FullName;

    public string getFullName()
    {
        return this.FirstName + "," + this.LastName;
    }

    public Employee()
    {
        Console.WriteLine("Employee class Constructor is called");
    }

    public Employee(string message) 
    {
        Console.WriteLine("Employee class custom Constructor is called");
    }
}

public class FullTimeEmployee: Employee
{
    public float YearlySalary;
    public FullTimeEmployee(): base("Call this constructor")
    {
        Console.WriteLine("FullTimeEmployee class Constructor is called");
    }
}

public class PartTimeEmployee: Employee
{
    public float HourlySalary;

    public PartTimeEmployee()
    {
        Console.WriteLine("PartTimeEmployee class Constructor is called");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FTE FN";
        FTE.LastName = "FTE LN";
        FTE.YearlySalary = 10000;
        FTE.getFullName();
        Console.WriteLine(FTE.getFullName());

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PTE FN";
        PTE.LastName = "PTE LN";
        Console.WriteLine(PTE.getFullName());
    }
}