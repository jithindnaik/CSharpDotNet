class Program
{
    public static void Main()
    {
        Console.WriteLine("Printing the int min value : " + int.MinValue + " and max value:" + int.MaxValue);

        Console.WriteLine("Printing the short min value : " + short.MinValue + " and max value:" + short.MaxValue);

        Console.WriteLine("Printing the byte min value : " + byte.MinValue + " and max value:" + byte.MaxValue);

        Console.WriteLine("Printing the long min value : " + long.MinValue + " and max value:" + long.MaxValue);

        // Precision of 7 digits after decimal
        Console.WriteLine("Printing the float min value : " + float.MinValue + " and max value:" + float.MaxValue);

        // Precision of 15 digits after decimal
        Console.WriteLine("Printing the double min value : " + double.MinValue + " and max value:" + double.MaxValue);
    }
}