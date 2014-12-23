using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Input first number :");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Input second number :");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Input third number :");
        double thirdNumber = double.Parse(Console.ReadLine());

        double bigger = Math.Max(firstNumber, secondNumber);
        double biggest = Math.Max(thirdNumber, bigger);

        Console.WriteLine("biggest ={0}", biggest);
    }
}
