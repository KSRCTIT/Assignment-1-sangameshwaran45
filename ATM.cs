using System;

class ATM
{
    static void Main()
    {
        int correctPin = 1234;
        int attempts = 0;
        bool access = false;

        while (attempts < 3)
        {
            Console.Write("Enter PIN: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin == correctPin)
            {
                Console.WriteLine("Access Granted");
                access = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong PIN");
                attempts++;
            }
        }

        if (!access)
            Console.WriteLine("Card Blocked");
    }
}
