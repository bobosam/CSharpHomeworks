using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Input integer:");
        int integerN = int.Parse(Console.ReadLine());
        bool check = true;

        if (integerN % 2 == 0)
        {
            check = false;
        }

        Console.WriteLine("Odd ? - " + check);
    }
}
