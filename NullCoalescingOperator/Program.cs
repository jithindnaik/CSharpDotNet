class Program
{
    public static void Main()
    {
        /*int? totalSales = null;
        
        if (totalSales == null)
        {
            Console.WriteLine("Total Sales is {0}", totalSales);
            return;
        }

        if (totalSales == 0 )
        {
            Console.WriteLine("Total Sales is {0}", totalSales);
        } else
        {
            Console.WriteLine("Total Sales is {0}", totalSales);
        }*/

        // With Null Coalescing Operator
        int? totalSales = 1000;

        int? sales = totalSales ?? 0;
        Console.WriteLine("Total Sales is {0}", sales);
    }
}