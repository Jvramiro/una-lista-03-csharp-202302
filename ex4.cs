using System;

public class Exercise_04
{
    public void run()
    {
        Console.Write("Enter the operation code (1 for perimeter, 2 for area, 3 for volume): ");
        int operation_code = int.Parse(Console.ReadLine());

        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());

        double pi = 3.141592;

        switch (operation_code)
        {
            case 1:
                double perimeter = 2 * pi * radius;
                Console.WriteLine($"The perimeter of the circle is: {perimeter:F2}");
                break;
            case 2:
                double area = pi * radius * radius;
                Console.WriteLine($"The area of the circle is: {area:F2}");
                break;
            case 3:
                double volume = (4.0 / 3.0) * pi * Math.Pow(radius, 3);
                Console.WriteLine($"The volume of the sphere is: {volume:F2}");
                break;
            default:
                Console.WriteLine("Invalid operation code.");
                break;
        }
    }
}
