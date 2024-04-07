// This is Single Line Comment

/*
This 
    Is 
      Multiline
                Comment*/


/// <summary>
/// This is a sample Program to show instantiation
/// </summary>
class Program: Person
{
    public static void Main(string[] args)
    {
        Person p = new Person();

    }

}


public class Person
{
    public Person() {
        Console.WriteLine("Constructor on Person class invoked");
    }
}
