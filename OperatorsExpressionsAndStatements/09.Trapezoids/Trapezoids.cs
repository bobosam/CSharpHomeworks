using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Input side A :");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Input side B :");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Input height h :");
        double heightH = double.Parse(Console.ReadLine());

        double area = (sideA + sideB) * 0.5 * heightH;

        Console.WriteLine("area :" + area);
    }
}
