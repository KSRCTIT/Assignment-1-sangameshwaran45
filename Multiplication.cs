using System;

class Multiplication
{
    static void Main()
    {
        char choice = 'Y';
        while (choice == 'Y' || choice == 'y')
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }

            Console.Write("Do you want to try another number (Y/N)? ");
            choice = char.Parse(Console.ReadLine());
        }
    }
}
