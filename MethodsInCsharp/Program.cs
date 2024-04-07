class Program {
    static int sum = 0;
    int num1 = 5;
    int num2 = 7;
    public static void Main()
    {
        Program p = new Program();
        Program.sum = p.CalculateSum(p.num1, p.num2);
        Program.PrintSum();
    }

    public int RecieveInputs()
    {
        return num1 + num2;
    }

    public int CalculateSum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void PrintSum() {
        Console.WriteLine(Program.sum);
    }
}
