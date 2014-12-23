using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Input first number :");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Input second number :");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Input third number :");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine();
        Console.WriteLine("The sum is :{0}" , sum);
    }
}
