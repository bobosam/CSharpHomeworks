using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInGivenRange
{
    static void Main()
    {
        bool check;
        int startNumber = 0;
        int endNumber = 0;

        do
        {
            Console.Write("Start number --> ");
            check = int.TryParse(Console.ReadLine(), out startNumber);
        } while (false == check);

        do
        {
            Console.Write("End number --> ");
            check = int.TryParse(Console.ReadLine(), out endNumber);
        } while (false == check);

        if (2 > startNumber)
        {
            startNumber = 2;
        }

        List<int> primeList = FindPrimesInRange(startNumber, endNumber);

        if (0 == primeList.Count)
        {
            Console.WriteLine("Empty list");
        }
        else
        {
            PrintPrimeList(primeList);
        }
    }

    static List<int> FindPrimesInRange (int startNumber,int endNumber)
    {
        List<int> primeNumbers = new List<int>();
        bool checkPrime = true;

        for (int checkNumber = startNumber; checkNumber <= endNumber; checkNumber++)
        {
            for (int j = 2; j <= Math.Sqrt(checkNumber);j ++)
            {
                if (0 == checkNumber %j)
                {
                    checkPrime = false;
                }
            }

            if (true == checkPrime)
            {
                primeNumbers.Add(checkNumber);
            }

            checkPrime = true;
        }
        return primeNumbers;
    }

    static void PrintPrimeList(List<int>primeList)
    {
        for (int i = 0; i < primeList.Count; i++)
        {
            if (i < (primeList.Count - 1))
            {
                Console.Write(primeList[i] + ", ");
            }
            else
            {
                Console.WriteLine(primeList[i]);
            }
        }
    }
}
