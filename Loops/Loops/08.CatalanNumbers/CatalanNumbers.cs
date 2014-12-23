using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        bool check;
        int numberN;
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialN1 = 1;

        do
        {
            Console.Write("N -->");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        for (int i = 1; i <= (numberN * 2); i++)
        {
            factorial2N = factorial2N * i;

            if (i == numberN)
            {
                factorialN = factorial2N;
            }

            if (i == (numberN +1))
            {
                factorialN1 = factorial2N;
            }
        }

        BigInteger result = factorial2N / (factorialN1 * factorialN);
        Console.WriteLine("Cn = {0}" , result);
    }
}
