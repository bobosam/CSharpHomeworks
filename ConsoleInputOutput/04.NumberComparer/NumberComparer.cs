using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Input first number a:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Input second number b:");
        double secondNumber = double.Parse(Console.ReadLine());

        double greater = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("Greater = {0}",greater);
    }
}
