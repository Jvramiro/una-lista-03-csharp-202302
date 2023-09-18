using System;

public class Exercise_01
{
    public void run()
    {   
        Console.WriteLine("Exercise 01");
        Console.WriteLine("Input the first number: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the second number: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the third number: ");
        double number3 = double.Parse(Console.ReadLine());

        double[] numbers = {number1, number2, number3};

        double min_value = numbers.Min();
        double max_value = numbers.Max();

        Console.WriteLine("The max value is: " + max_value);
        Console.WriteLine("The min value is: " + min_value);

        double mean = (number1 + number2 + number3) / 3;
        Console.WriteLine("The average is: " + mean);
    }
}