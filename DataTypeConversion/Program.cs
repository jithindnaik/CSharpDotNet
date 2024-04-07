class Program
{
   public static void Main()
    {
        int i = 10;
        float j = i;
        
        Console.WriteLine("Implicit Conversion performed on variable i into j, J value = " + j);

        float m = 200.134f;
        int n = Convert.ToInt32(m);
        int o = (int) m;
        Console.WriteLine("Explicit Conversion performed on variable m into n, N value = " + n);
        Console.WriteLine("Explicit Conversion performed on variable m into 0, O value = " + o);


        // Parse and Try Parse Method 

        // Parse 
        string q = "500";
        int l = int.Parse(q);
        Console.WriteLine("Parsed integer from string " + l);

        // Try Parse
        string x = "500";
        int z = 0;
        bool y = int.TryParse(x, out z);
        if (y)
        {
            Console.WriteLine("Parsed integer from string " + z);
        } else
        {
            Console.WriteLine("Please enter valid input");
        }


    }

}