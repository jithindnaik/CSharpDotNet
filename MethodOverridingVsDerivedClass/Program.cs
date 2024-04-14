public class BaseClass1
{
    public virtual void TestMethod()
    {
        Console.WriteLine("Base Class1 Test Method being invoked.");
    }
}

public class OverridenDerivedClass : BaseClass1
{
    public override void TestMethod()
    {
        Console.WriteLine("OverridenDerivedClass Test Method being invoked.");
    }
}

public class BaseClass2
{
    public virtual void TestMethod()
    {
        Console.WriteLine("BaseClass2 Test Method being invoked.");
    }
}

public class MethodHiddenDerivedClass : BaseClass2
{
    public new void TestMethod()
    {
        Console.WriteLine("MethodHiddenDerivedClass Test Method being invoked.");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        BaseClass1 b1 = new OverridenDerivedClass();
        b1.TestMethod();

        BaseClass2 b2 = new MethodHiddenDerivedClass();
        b2.TestMethod();
    }
}