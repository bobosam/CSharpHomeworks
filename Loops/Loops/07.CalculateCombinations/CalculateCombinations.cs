using System;
using System.Numerics;

class CalculateCombinations
{
    static void Main()
    {
        bool check;
        BigInteger factorialN = 1;
        BigInteger factorialK =1;
        BigInteger factorialNK =1;
        int numberN , numberK , numberNK ;

        do
        {
            Console.Write("N -->");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        do
        {
            Console.Write("K -->");
            check = int.TryParse(Console.ReadLine(), out numberK);
        } while (false == check);

        numberNK = numberN - numberK;

        for (int i = 1; i <= numberN; i++)
        {
            factorialN = factorialN * i;

            if (i == numberK)
            {
                factorialK = factorialN;  
            }

            if (i == numberNK)
            {
                factorialNK = factorialN; 
            }
        }

        BigInteger result =factorialN /(factorialK * factorialNK);
        Console.WriteLine("Combinations = {0}",result);
    }
}
