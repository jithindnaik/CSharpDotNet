public class BaseClass
{
    public void TestMethod()
    {
        Console.WriteLine("Base Class Test Method is Invoked");
    }
}

public class DerivedClass : BaseClass
{
    public new void TestMethod()
    {
        Console.WriteLine("DerivedClass Class Test Method is Invoked");
    }
}

public class DerivedClass1 : BaseClass
{
    public new void TestMethod()
    {
        base.TestMethod();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //BaseClass b = new BaseClass();
        //b.TestMethod();

        BaseClass derivedClass = new DerivedClass();
        // invoking base class test method
        derivedClass.TestMethod();

        DerivedClass d = new DerivedClass();
        // invoking base class test method
        ((BaseClass)d).TestMethod();

        DerivedClass1 d1 = new DerivedClass1();
        d1.TestMethod();

    }
}