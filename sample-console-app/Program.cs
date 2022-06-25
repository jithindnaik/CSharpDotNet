using System.Collections.Generic;

namespace CSharpDotNetCore {
    public class SampleConsoleApp {
        public static void Main(string[] args) {
            // Console.WriteLine("Hello " + args[0] + ", Welcome to CSharp!!");
            if (args.Length > 0) {
            Console.WriteLine($"Hello {args[0]}, Welcome to CSharp!!");
            } else {
                Console.WriteLine($"Hello User, Welcome to CSharp!!");
            } 

            int var1 = 10;
            int var2 = 20;
            int sum = var1 + var2;
            Console.WriteLine(var1+var2);

            double var11 = 10.123;
            double var12 = 15.124;
            Console.WriteLine(var11 + var12);

            var listItems = new double[3];
            listItems[0] = 10;
            listItems[1] = 20;
            listItems[2] = 30;

            var sumList = listItems[0] + listItems[1] + listItems[2];
            System.Console.WriteLine(sumList);

            // var arrInit = new double[3] {10, 20, 30, 40, 50};
            // var arrInit = new double[] {10, 20, 30, 40, 50};
            var arrInit = new [] {10, 20, 30, 40, 50};
            sumList = 0;
            foreach(double num in arrInit) {
                sumList+= num;
            }
            System.Console.WriteLine(sumList);

            // List<double> grades = new List<double>();
            var grades = new List<double>(){10.456, 20, 30};
            grades.Add(100);
            sumList = 0;
            foreach(var num in grades) {
                sumList+= num;
            }
            System.Console.WriteLine(sumList);
            var len = grades.Count;
            System.Console.WriteLine($"Avg grade is :: {sumList/len:N3}");
        }
    }
}
