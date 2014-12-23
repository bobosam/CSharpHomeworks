using System;

class NumbersFromOneToN
{
    static void Main()
    {
        bool check = true;
        int n;

        do 
        {
            Console.Write("Please enter a integer N:");
            check = int.TryParse(Console.ReadLine(), out n);
        } while (false == check);

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }

        Console.WriteLine();
    }
}
