using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Input radius r :");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("r    perimeter    area");
        Console.WriteLine("{0,-7}{1,-11:f2}{2:f2}",radius , perimeter , area );
    }
}
