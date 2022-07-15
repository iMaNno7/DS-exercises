using DataStructure;
using Math = DataStructure.Math;
var math = new Math();
var file = new FileUtils();

Console.WriteLine("1- Write a program to find the factorial " +
    "of a given number using recursion.\r\n Number = ");
Console.WriteLine(math.Factorial(Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("2- Write a program to calculate the power of any number using recursion.\r\n" +
    "enter number then power = ");
Console.WriteLine(math.Power(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("3- Write a program to get the reverse of a string using recursion.\r\n" +
    "string = ");
Console.WriteLine(Console.ReadLine()?.ReverseString());
//Console.WriteLine(Console.ReadLine()?.CustomReverse());

Console.WriteLine("4- Write a program with LINQ to find the square of each number in a giving array.\r\n ");
foreach (var item in math.Square(new int[] { 5, 6, 7 }))
    Console.WriteLine($"{item.Key} :{item.Value}");

Console.WriteLine("5- Write a program with LINQ to display the characters and frequency of each character from giving string.\r\n" +
    "string =");

foreach (var item in Console.ReadLine()?.Frequency())
    Console.WriteLine(item);

Console.WriteLine("6- Write a program to create a blank file in the disk newly\r\n" +
    "path = ");
var path = file.Create(Console.ReadLine());
Console.WriteLine(file.IsExists(path));