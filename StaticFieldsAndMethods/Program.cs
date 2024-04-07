class Program
{
    //instance field
    //float PI = 3.1482f;

    int radius = 0;
    double area = 0.0;

    // static field
    // static double PI = System.Math.PI;

    static double PI = 0;

    // Static constructor
    static Program()
    {
        Console.WriteLine("Static Constructor Invoked");
        PI = Math.PI;
    }

    // instance constructor
    Program(int radius)
    {
        Console.WriteLine("Instance Constructor Invoked");
        this.radius = radius;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Main Method Statement Starts ---");

        // Class instance creation
        Program p = new Program(2);

        // Class instance creation
        Program p1 = new Program(5);

        p.CalculateArea(p.radius);
        p1.CalculateArea(p1.radius);

    }

    public void CalculateArea(int radius)
    {
        this.area = PI * radius * radius;
        Console.WriteLine("Area of the circle = {0}", this.area);
    }

}