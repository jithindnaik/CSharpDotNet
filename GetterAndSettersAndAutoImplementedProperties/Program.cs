public class Program
{
    private string _FirstName;
    private string _UniqueEnrollmentId = "1111 0000 1111";
    public string FirstName
    {
        get
        {
            return this._FirstName;
        }
        set
        {
            this._FirstName = value;
        }
    }
    public string LastName
    {
        // auto implemented properties
        get;
        set;
    }

    public string uniqueEnrollmentId
    {
        get
        {
            return this._UniqueEnrollmentId;
        }
    }

    public static void Main(string [] args)
    {
        Program p = new Program();
        p.FirstName = "Test FN";
        p.LastName = "Test LN";
        Console.WriteLine(p.FirstName);
        Console.WriteLine(p.LastName);
        Console.WriteLine(p.uniqueEnrollmentId);
    }
}