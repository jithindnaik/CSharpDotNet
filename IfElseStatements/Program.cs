class Program
{
    public static void Main()
    {
        int age = 19;
        if (age < 0)
        {
            Console.WriteLine("You entered an invalid age.");
        }
        if (age < 10)
        {
            Console.WriteLine("You are a kid");
        } else if (age < 18)
        {
            Console.WriteLine("You are a Minor");
        } else
        {
            Console.WriteLine("You are a Major");
        }
    }
}