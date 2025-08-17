using System;

class Temperature
{
    static void Main()
    {
        Console.Write("Enter temperature: ");
        float temperature = float.Parse(Console.ReadLine());

        if (temperature > 37.0f)
            Console.WriteLine("Fever");
        else
            Console.WriteLine("Normal");
    }
}
