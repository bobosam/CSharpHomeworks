using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        bool check = true;
        int numberN;

        do
        {
            Console.Write("Please enter a integer N:");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        for (int counter = 1; counter <= numberN; counter++)
        {
            int div3 = counter % 3;
            int div7 = counter % 7;

            if ((0 == div3 ) || (0 == div7))
            {
                continue;
            }
            Console.Write("{0} ", counter);
        }
        Console.WriteLine();
    }
}
