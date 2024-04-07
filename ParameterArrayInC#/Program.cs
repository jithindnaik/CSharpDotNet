class Program
{
    public static void Main(string[] args) { 
        int[] arr = new int[2];
        arr[0] = 1;
        arr[1] = 2;
        //Program.ParmsArray(arr);
        // Program.ParmsArray()
        Program.ParmsArray(1,2,3,4,5);
    }

    public static void ParmsArray(params int[] arr)
    {
        Console.WriteLine("Array has {0} elements", arr.Length);

        foreach (int ele in arr)
        {
            Console.WriteLine(ele);
        }
    }
}
