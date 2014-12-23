using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Console.Write("Input coordinate X :");
        double coordinateX = double.Parse(Console.ReadLine());
        Console.Write("Input coordinate Y :");
        double coordinateY = double.Parse(Console.ReadLine());
        string output = "Yes";

        //check for coordinate inside of rectangle
        if (coordinateY <= 1)
        {
            output = "No";
        }
        else
        {
            //check for coordinate inside of circle
            double length = Math.Sqrt((coordinateX - 1) * (coordinateX - 1) + (coordinateY - 1) * (coordinateY - 1));
            if (length > 1.5)
            {
                output = "No";
            }
        }

        Console.WriteLine("Inside K and outside of R :" + output);
    }
}
