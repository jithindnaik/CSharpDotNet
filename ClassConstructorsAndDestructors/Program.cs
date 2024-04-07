class Program
{
    string FirstName;
    string LastName;    

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.PrintName(p.FirstName,p.LastName);

        Program p1 = new Program("TestFirstName", "TestLastName");
        p1.PrintName(p1.FirstName, p1.LastName);
    }

    Program() : this("NoFirstName", "NoLastName")
    {
        // Overriden the default constructor
    }

    ~Program()
    {
        // Clean up resources in the destructor
    }

    Program(string FirstName, string LastName) {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    public void PrintName(string FirstName, string LastName)
    {
        Console.WriteLine("FirstName: {0}, LastName: {1}", FirstName, LastName);
    }
}