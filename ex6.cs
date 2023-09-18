using System;

class Exercise_06
{
    public void run()
    {
        Console.Write("Enter the first integer number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer number: ");
        int num2 = int.Parse(Console.ReadLine());

        int minNum = Math.Min(num1, num2);
        int maxNum = Math.Max(num1, num2);

        Random random = new Random();
        int randomNumber = random.Next(minNum, maxNum + 1);

        if (randomNumber % 2 == 0)
        {
            Console.WriteLine($"Generated number: {randomNumber} (even)");
        }
        else
        {
            Console.WriteLine($"Generated number: {randomNumber} (odd)");
        }
    }
}
