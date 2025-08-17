using System;

class Quiz
{
    static void Main()
    {
        Console.Write("Enter starting score: ");
        int score = int.Parse(Console.ReadLine());
        Console.WriteLine("Starting Score = " + score);

        Console.Write("Enter correct answers count: ");
        int correct = int.Parse(Console.ReadLine());
        score += 10 * correct;
        Console.WriteLine("After correct answers = " + score);

        Console.Write("Enter wrong answers count: ");
        int wrong = int.Parse(Console.ReadLine());
        score -= 5 * wrong;
        Console.WriteLine("After wrong answers = " + score);

        Console.Write("Apply bonus round? (Y/N): ");
        char bonus = char.Parse(Console.ReadLine());
        if (bonus == 'Y' || bonus == 'y')
            score *= 2;
        Console.WriteLine("After bonus round = " + score);

        Console.Write("Apply penalty? (Y/N): ");
        char penalty = char.Parse(Console.ReadLine());
        if (penalty == 'Y' || penalty == 'y')
            score /= 5;
        Console.WriteLine("After penalty = " + score);
    }
}
