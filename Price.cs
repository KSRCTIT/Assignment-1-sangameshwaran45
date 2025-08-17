using System;

class Price
{
    static void Main()
    {
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter discount %: ");
        double discount = double.Parse(Console.ReadLine());

        double finalPrice = price - (price * discount / 100);
        Console.WriteLine("Final Price: " + finalPrice);
    }
}
