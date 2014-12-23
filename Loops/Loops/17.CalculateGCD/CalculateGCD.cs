using System;

class CalculateGCD
{
    static void Main()
    {
        bool check;
        int numberA , numberB , maxNumber , minNumber;
        int remainder = 0;

        do
        {
            Console.Write("A --> ");
            check = int.TryParse(Console.ReadLine(), out numberA);

        } while (false == check);

        do
        {
            Console.Write("B --> ");
            check = int.TryParse(Console.ReadLine(), out numberB);
            
        } while (false == check);

        if (numberB > numberA)
        {
            maxNumber = numberB;
            minNumber = numberA;
        }
        else
        {
            maxNumber = numberA;
            minNumber = numberB;
        }

        while (0 == remainder)
        {
            remainder = maxNumber % minNumber;
            maxNumber = minNumber;
            minNumber = remainder;
        }

        Console.WriteLine("GCD --> {0}", minNumber);
    }
}
