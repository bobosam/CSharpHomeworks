using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        bool check;
        int numberN , numberX ;
        double sum = 1;

        do
        {
            Console.Write("n --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        do
        {
            Console.Write("x --> ");
            check = int.TryParse(Console.ReadLine(), out numberX);
        } while (false == check);

        for (int i = 1; i <= numberN; i++)
        {
            sum = sum + ((double)CalculateFactorial(i) / Math.Pow(numberX,i)) ;
        }

        Console.WriteLine("sum S={0:f5}" , sum);
    }
    /// <summary>
    /// create metod for calculate factorial
    /// </summary>
    /// <param name="numberN"></param>
    /// <returns></returns>
    static BigInteger CalculateFactorial(int numberN)
    {
        BigInteger nFactorial = 1;

        for (int i = 1; i <= numberN; i++)
        {
            nFactorial =nFactorial * i;
        }

        return nFactorial;
    }
}


