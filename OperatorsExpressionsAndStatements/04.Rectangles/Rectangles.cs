using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Input width :");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Input height :");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("Perimeter :" + perimeter);
        Console.WriteLine("Area :" + area);
    }
}
