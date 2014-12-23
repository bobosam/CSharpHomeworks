using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Input start number :");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input end number :");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("How many numbers:{0}", counter);
    }
}
