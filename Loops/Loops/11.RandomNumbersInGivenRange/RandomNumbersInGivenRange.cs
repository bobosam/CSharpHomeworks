using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        bool check;
        int numberN, min, max;

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        do
        {
            Console.Write("Min --> ");
            check = int.TryParse(Console.ReadLine(), out min);
        } while (false == check);

        do
        {
            Console.Write("Max --> ");
            check = int.TryParse(Console.ReadLine(), out max);
        } while (false == check);

        Random rnd = new Random();

        for (int i = 0; i < numberN; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max+1));
        }

        Console.WriteLine();
    }
}
