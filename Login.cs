using System;

class Login
{
    static void Main()
    {
        Console.Write("Enter login status (true/false): ");
        bool loginSuccess = bool.Parse(Console.ReadLine());

        if (loginSuccess)
            Console.WriteLine("Login successful");
        else
            Console.WriteLine("Access denied");
    }
}
