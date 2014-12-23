using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        bool check;
        int numberN = 0;

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        int[] numbers = new int[numberN];

        for (int i = 0; i < numberN; i++)
        {
            do
            {
                Console.Write("{0} --> ", i + 1);
                check = int.TryParse(Console.ReadLine(), out numbers[i]);
            } while (false == check);
        }
        Console.WriteLine();
        Array.Sort(numbers);

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}
