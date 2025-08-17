using System;

class Gender
{
    static void Main()
    {
        Console.Write("Enter gender (M/F): ");
        char gender = char.Parse(Console.ReadLine());

        if (gender == 'M')
            Console.WriteLine("Male");
        else if (gender == 'F')
            Console.WriteLine("Female");
        else
            Console.WriteLine("Other");
    }
}
