using System;

class Marks
{
    static void Main()
    {
        int[] marks = new int[5];
        int sum = 0;

        Console.WriteLine("Enter marks of 5 subjects:");
        for (int i = 0; i < 5; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
            sum += marks[i];
        }

        double avg = sum / 5.0;
        Console.WriteLine("Average = " + avg);

        if (avg >= 40)
            Console.WriteLine("Passed");
        else
            Console.WriteLine("Failed");
    }
}
