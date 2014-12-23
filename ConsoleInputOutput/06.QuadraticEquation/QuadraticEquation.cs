using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Input coefficient a:");
        double coeffA = double.Parse(Console.ReadLine());
        Console.Write("Input coefficient b:");
        double coeffB = double.Parse(Console.ReadLine());
        Console.Write("Input coefficient c:");
        double coeffC = double.Parse(Console.ReadLine());

        double discriminant = coeffB * coeffB - (4 * coeffA * coeffC);

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else
        {
            if (discriminant == 0)
            {
                double rootX = (-1 * coeffB) / (2 * coeffA);
                Console.WriteLine("X1 = X2 = {0}",rootX);
            }
            else
            {
                double rootX1 = (-1 * coeffB - Math.Sqrt(discriminant)) / (2 * coeffA);
                double rootX2 = (-1 * coeffB + Math.Sqrt(discriminant)) / (2 * coeffA);
                Console.WriteLine("X1 = {0}; X2 = {1}", rootX1, rootX2);
            }
        }
    }
}
