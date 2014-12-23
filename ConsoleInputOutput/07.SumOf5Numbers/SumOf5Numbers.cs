using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Input numbers string :");
        string inputString = Console.ReadLine();
        double sum = 0;

        string[] words = inputString.Split(' ');

        for (int i = 0; i < 5; i++)
        {
            double tmpDigit = double.Parse(words[i]);
            sum += tmpDigit;
        }

        Console.WriteLine("Sum ={0}",sum);
    }
}
