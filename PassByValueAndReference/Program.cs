class Program
{
    public static void Main(String[] args)
    {
        int k = 10;
        int i = 0;
        Program.UpdateJByValue(i);
        Program.UpdateJByRef(ref i);

        Console.WriteLine(k);
        Console.WriteLine(i);
    }

    public static void UpdateJByValue(int k)
    {
        int j = 0;
        k = j;
    }

    public static void UpdateJByRef(ref int i)
    {
        int j = 100;
        i = j;
    }
}