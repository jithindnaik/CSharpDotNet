using PATACA = ProjectA.TeamA.ClassA;
using PATACB = ProjectA.TeamB.ClassA;

class Program
{
    public static void Main(string[] args)
    {
        // Using fully qualified name in the invocation
        // ProjectA.TeamA.ClassA.PrintA();
        // ProjectA.TeamB.ClassA.PrintA();

        PATACA.PrintA();
        PATACB.PrintA();
    }
}