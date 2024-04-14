public class Program
{
    public string FirstName {  get; set; }
    public static void Main(string[] args)
    {
        System.Int32 x = 5;
        Program p1 = new Program();
        Program p2 = p1;
        p1.FirstName = "Rahul";
        Console.WriteLine(p1.FirstName);
        Console.WriteLine(p2.FirstName);
    }
    
}

public sealed class Test { }