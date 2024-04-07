class Program
{
    public static void Main()
    {
        bool isInputValid;
        int limit;
        int startCount = 0;

        Console.WriteLine("Please enter the limit to which even numbers need to be printed");
        isInputValid = int.TryParse(Console.ReadLine(), out limit);
       
        if (!isInputValid)
        {
            Console.WriteLine("Entered a valid input");
        } else
        {
            while (limit > 0)
            {
                startCount += 2;
                Console.Write("{0} ", startCount);
                limit -= 2;
            }
        }

        Console.WriteLine("-------------------------------------------------------------");

        {
            int count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 100);
        }

        Console.WriteLine("-------------------------------------------------------------");


        int [] arr = new int[10];
        arr = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }

        Console.WriteLine("-------------------------------------------------------------");

        int[] arr2 = new int[5];
        arr2 = [5, 10, 15, 20, 25];

        foreach (int item in arr2)
        {
            Console.Write(" " + item);
        }

        Console.WriteLine("-------------------------------------------------------------");

        int[] arr3 = new int[5];
        arr3 = [5, 10, 15, 20, 25];

        for (int i = 0; i < arr3.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }
            if (i == 4)
            {
                break;
            }
            Console.Write(" " + arr3[i]);
        }
    }
}