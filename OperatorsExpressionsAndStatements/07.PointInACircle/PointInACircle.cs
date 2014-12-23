using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Input X :");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Input Y :");
        double y = double.Parse(Console.ReadLine());
        bool check = true;

        double distance = Math.Sqrt(x * x + y * y);

        if (distance > 2)
        {
            check = false;
        }

        Console.WriteLine("Inside :" + check);
    }
}
