using System;

public class Exercise_02
{
    public void run()
    {
        Console.Write("Purchase value: $ ");
        double purchase_value = double.Parse(Console.ReadLine());

        Console.Write("Paid value: $ ");
        double paid_value = double.Parse(Console.ReadLine());

        double change = paid_value - purchase_value;

        if (change < 0)
        {
            Console.WriteLine("Insufficient paid amount to complete the purchase.");
        }
        else
        {
            Console.WriteLine($"Change: $ {change:F2}");

            int[] bills = { 50, 20, 10, 5, 2, 1 };
            int[] bills_quantity = new int[6];

            for (int i = 0; i < bills.Length; i++)
            {
                bills_quantity[i] = (int)(change / bills[i]);
                change -= bills_quantity[i] * bills[i];
            }

            Console.WriteLine("Change bills:");
            for (int i = 0; i < bills.Length; i++)
            {
                if (bills_quantity[i] > 0)
                {
                    Console.WriteLine($"$ {bills[i]}.00 bills: {bills_quantity[i]}");
                }
            }
        }
    }
}
