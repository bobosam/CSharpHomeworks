using System;
using System.Linq;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        bool chekInn;
        int countN;

        do
        {
            Console.Write("Please enter a integer N: ");
            chekInn = int.TryParse(Console.ReadLine(), out countN);
        } while (false == chekInn);

        int[] numbers = new int[countN];

        for (int i = 0; i < countN; i++)
        {
            do
            {
                Console.Write("{0}. -->" , i+1);
                chekInn = int.TryParse(Console.ReadLine(), out numbers[i]);
            } while (false == chekInn);
        }

        int min = numbers.Min();
        int max = numbers.Max();
        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine("min = {0}" , min);
        Console.WriteLine("max = {0}" , max);
        Console.WriteLine("sum = {0}" , sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}
