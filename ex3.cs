using System;

public class Exercise_03
{
    public void run()
    {
        Console.Write("Enter the coefficient a: ");
        double coefficient_a = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient b: ");
        double coefficient_b = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient c: ");
        double coefficient_c = double.Parse(Console.ReadLine());

        if (coefficient_a == 0 && coefficient_b == 0 && coefficient_c != 0)
        {
            Console.WriteLine("Incorrectly provided coefficients.");
        }
        else if (coefficient_a == 0 && coefficient_b != 0)
        {
            Console.WriteLine("This is a linear equation.");
            double root = -coefficient_c / coefficient_b;
            Console.WriteLine($"The real root of the equation is: {root:F2}");
        }
        else
        {
            double discriminant = coefficient_b * coefficient_b - 4 * coefficient_a * coefficient_c;

            if (discriminant < 0)
            {
                Console.WriteLine("This equation has no real roots.");
            }
            else if (discriminant == 0)
            {
                double root = -coefficient_b / (2 * coefficient_a);
                Console.WriteLine("This equation has two equal real roots.");
                Console.WriteLine($"The real root of the equation is: {root:F2}");
            }
            else
            {
                double root1 = (-coefficient_b + Math.Sqrt(discriminant)) / (2 * coefficient_a);
                double root2 = (-coefficient_b - Math.Sqrt(discriminant)) / (2 * coefficient_a);
                Console.WriteLine("This equation has two different real roots.");
                Console.WriteLine($"The real roots of the equation are: {root1:F2} and {root2:F2}");
            }
        }
    }
}
