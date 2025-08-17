using System;

class Literal
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter temperature: ");
        float temperature = float.Parse(Console.ReadLine());

        Console.Write("Enter grade: ");
        char grade = char.Parse(Console.ReadLine());

        Console.Write("Enter pass status (true/false): ");
        bool isPassed = bool.Parse(Console.ReadLine());

        Console.WriteLine($"{age} -> {age.GetType()}");
        Console.WriteLine($"{temperature} -> {temperature.GetType()}");
        Console.WriteLine($"{grade} -> {grade.GetType()}");
        Console.WriteLine($"{isPassed} -> {isPassed.GetType()}");
    }
}
