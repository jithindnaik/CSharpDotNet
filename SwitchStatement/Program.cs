class MyClass
{
    public static void Main()
    {
        string coffeeType = "strong";

        switch (coffeeType)
        {
            case "strong":
                Console.WriteLine("You have ordered {0} coffee", coffeeType);
                break;
            case "medium":
                Console.WriteLine("You have ordered {0} coffee", coffeeType);
                break;
            case "light":
                Console.WriteLine("You have ordered {0} coffee", coffeeType);
                break;
            default:
                Console.WriteLine("You have ordered normal coffee", coffeeType);
                break;
        }
    }
}