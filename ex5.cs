using System;

public class Exercise_05
{
    public void run()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the operation symbol (+, -, *, /, or ^): ");
        char operationSymbol = char.Parse(Console.ReadLine());

        double result = 0;

        switch (operationSymbol)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            case '^':
                result = Math.Pow(num1, num2);
                break;
            default:
                Console.WriteLine("Error: Invalid operation symbol.");
                return;
        }

        Console.WriteLine($"Result of the operation: {result}");
    }
}
