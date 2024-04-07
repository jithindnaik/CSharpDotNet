class Program
{
    public static void Main(string[] args)
    {
        int Sum = 0;
        int Product = 0;
        Calculate(10, 20, out Sum, out Product);

        Console.WriteLine(Sum);
        Console.WriteLine(Product);
    }

    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }
}