public class BaseClass
{
    public virtual void TestMethod()
    {
        Console.WriteLine("Test Method being invoked from the BaseClass");
    }
}

public class DerivedClass1: BaseClass
{
    public override void TestMethod()
    {
        Console.WriteLine("Test Method being invoked from the DerivedClass1");
    }
}

public class DerivedClass2 : BaseClass
{
    public override void TestMethod()
    {
        Console.WriteLine("Test Method being invoked from the DerivedClass2");
    }
}

public class DerivedClass3 : BaseClass
{
    public override void TestMethod()
    {
        Console.WriteLine("Test Method being invoked from the DerivedClass3");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BaseClass[] baseClasses = new BaseClass[3];
        baseClasses[0] = new DerivedClass1();
        baseClasses[1] = new DerivedClass2();
        baseClasses[2] = new DerivedClass3();

        foreach (var item in baseClasses)
        {
            item.TestMethod();
        }
    }
}