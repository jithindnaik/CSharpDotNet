class Program
{
    public static void Main()
    {
        // Prompt the user to enter name
        Console.WriteLine("Enter your name");

        // Read the input from the console
        string UserName = Console.ReadLine();

        // Print the concantenated output into the screen
        // Console.WriteLine("Entered name is " + UserName);

        Console.WriteLine("Entered name is {0}", UserName);
    }
} 
