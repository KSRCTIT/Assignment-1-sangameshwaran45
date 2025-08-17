using System;

class Player
{
    static void Main()
    {
        Console.Write("Enter Player A score: ");
        int playerA = int.Parse(Console.ReadLine());

        Console.Write("Enter Player B score: ");
        int playerB = int.Parse(Console.ReadLine());

        Console.WriteLine("Player A > Player B: " + (playerA > playerB));
        Console.WriteLine("Scores equal: " + (playerA == playerB));
        Console.WriteLine("Player A <= Player B: " + (playerA <= playerB));
        Console.WriteLine("Player B >= Player A: " + (playerB >= playerA));
    }
}
