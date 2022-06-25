// Simple Sum Operation
int num1 = 10;
int num2 = 20;
int num3 = 30;
var sum = num1 + num2 + num3;
System.Console.WriteLine(sum); 

// Using a loop to take a list input and print the sum
//int arr = new int[3];
// var arr = new int[3] {10, 20, 30};
var arr = new [] {10, 20, 30, 40, 50};
var sum1 = 0;
foreach(var x in arr) {
    sum1 += x;
}
System.Console.WriteLine(sum1);

// Using a list to take the list of input and print the sum
// List<Double> grades = new List<Double> {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
var grades = new List<Double> {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
double gradeSum = 0;
foreach(var x in grades) {
    gradeSum += x;
}
System.Console.WriteLine(gradeSum);


// Compute Avg of the grades 
double avg = 0;
avg = (gradeSum / grades.Count);
System.Console.WriteLine($"Average of the grades :{avg:N2}"); // Avg grades to 2 decimal points
