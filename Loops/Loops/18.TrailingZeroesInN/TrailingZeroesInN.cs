using System;

class TrailingZeroesInN
{
    static void Main()
    {
        bool check;
        int numberN;
        int counter = 0;

        do
        {
            Console.Write("N --> ");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        //http://www.purplemath.com/modules/factzero.htm

        while (1 < numberN)
        {
            counter += numberN / 5;
            numberN = numberN / 5;
        }

        Console.WriteLine("Trailing zeroes of n! --> {0}" ,counter);
    }
}
