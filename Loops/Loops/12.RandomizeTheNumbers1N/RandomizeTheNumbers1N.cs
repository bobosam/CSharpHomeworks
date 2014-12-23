using System;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        bool check;
        int numberN;

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        int[] numbers = new int[numberN];
        Random rnd = new Random();
        int plays = rnd.Next(0, numberN);

        for (int i = 1; i <= numberN; i++)
        {
            while (0 != numbers[plays])
            {
                plays = rnd.Next(0, numberN);
            }

            numbers[plays] = i;
        }

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

        Console.WriteLine();
    }
}
