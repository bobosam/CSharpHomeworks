using System;
using System.Numerics;

class CalculateNDelK
{
    static void Main()
    {
        bool check;
        int numberN , numberK ;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        do
        {
            Console.Write("K --> ");
            check = int.TryParse(Console.ReadLine(), out numberK);
        } while (false == check);

        for (int i = 1; i <= numberN; i++)
        {
            factorialN = factorialN * i;

            if (i == numberK)
            {
                factorialK = factorialN;
            }
        }

        BigInteger calculate =factorialN / factorialK;
        Console.WriteLine("n!/k! = {0}" , calculate);
    }
}
