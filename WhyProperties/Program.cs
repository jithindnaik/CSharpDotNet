public class PropertiesAndMethodsClass
{

    private int _id = 0;
    private string _FirstName;
    private string _LastName;
    private int _passMark = 40;

    public string getFirstName()
    {
        return string.IsNullOrEmpty(this._FirstName) ? string.Empty : this._FirstName;
    }

    public int getPassMark()
    {
        return this._passMark;
    }

    public void setFirstName(string FirstName)
    {
        if (string.IsNullOrEmpty(FirstName))
        {
            throw new Exception("FirstName cannot be set to null");
        } else
        {
            this._FirstName = FirstName;
        }
    }

    
}

public class Program
{
    public static void Main(string[] args)
    {
        PropertiesAndMethodsClass cc = new PropertiesAndMethodsClass();
        cc.setFirstName("Test");
        Console.WriteLine(cc.getFirstName());

        Console.WriteLine(cc.getPassMark());

        //cc.setFirstName("");
        //Console.WriteLine(cc.getFirstName());
    }
}