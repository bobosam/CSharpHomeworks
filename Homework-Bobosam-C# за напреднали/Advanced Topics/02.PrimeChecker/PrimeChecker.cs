using System;

class PrimeChecker
{
    static void Main()
    {
        bool check;
        long numberN = 0;

        do
        {
            Console.Write("N --> ");
            check = long.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        bool result = IsPrime(numberN);
        Console.WriteLine("Is prime {0} --> {1}", numberN ,result );
    }

    static bool IsPrime(long number)
    {
        bool checkPrime = true;

        if (2 > number)
        {
            checkPrime = false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (0 == number %i)
            {
                checkPrime = false;
            }
        }
        return checkPrime;
    }
}
