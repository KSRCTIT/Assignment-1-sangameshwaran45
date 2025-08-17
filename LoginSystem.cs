using System;

class LoginSystem
{
    static void Main()
    {
        string username = "admin";
        string password = "1234";

        Console.Write("Enter username: ");
        string enteredUser = Console.ReadLine();

        Console.Write("Enter password: ");
        string enteredPass = Console.ReadLine();

        if (enteredUser == username && enteredPass == password)
            Console.WriteLine("Access Granted");
        else
            Console.WriteLine("Access Denied");

        Console.WriteLine("OR condition: " + (enteredUser == username || enteredPass == password));
        Console.WriteLine("NOT condition (username check): " + (!(enteredUser == username)));
    }
}
