public struct Program
{
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public string getFullName { 
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public Program(string _FirstName, string _LastName)
    {
        this.FirstName = _FirstName;
        this.LastName = _LastName;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.FirstName = "Mark";
        program.LastName = "Wough";
        Console.WriteLine(program.getFullName);

        Program program1 = new Program("Brane", "Lara");
        Console.WriteLine(program1.getFullName);
    }
}
