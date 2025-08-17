using System;

class Age
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine("Eligible to Vote");
        else
            Console.WriteLine("Not Eligible");
    }
}
