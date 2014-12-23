using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Input integer N:");
        int digitN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= digitN; i++)
        {
            Console.WriteLine(i);
        }
    }
}
