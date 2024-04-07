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


namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void PrintA()
            {
                Console.WriteLine("Print A invoked from PA-TA-CA");
            }
        }
    }
}


namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void PrintA()
            {
                Console.WriteLine("Print A invoked from PA-TB-CA");
            }
        }
    }
}