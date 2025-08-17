using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Enter number A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter number B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Total apples = " + (a + b));
        Console.WriteLine("Difference of pencils = " + (a - b));
        Console.WriteLine("Total pages when A pages are copied B times = " + (a * b));
        Console.WriteLine("Chocolates per kid = " + (a / b));
        Console.WriteLine("Leftover candies = " + (a % b));
    }
}
