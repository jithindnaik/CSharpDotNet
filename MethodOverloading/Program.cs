public class Program
{
    public static void Main(string[] args)
    {
        TestClass1.TestMethod(10, 22.5f);

        TestClass1.TestMethod(22.5f, 10);

        double sum = 0;
        TestClass1.TestMethod(22.5f, 10, out sum);
        Console.WriteLine(sum);
    }
}

public class TestClass1
{
    public static void TestMethod(int FN, float SN)
    {
        Console.WriteLine(FN + SN);
    }

    public static void TestMethod(float FN, float SN)
    {
        Console.WriteLine(FN + SN);
    }

    public static void TestMethod(float FN, int TN, out double FOURTHNUM)
    {
        FOURTHNUM = FN + TN;
    }
}