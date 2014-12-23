using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Input count N:");
        int countN = int.Parse(Console.ReadLine());
        Console.WriteLine("Input {0} elements:", countN);
        double sum = 0;

        for (int i = 0; i < countN; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("Sum ={0}",sum);
    }
}
