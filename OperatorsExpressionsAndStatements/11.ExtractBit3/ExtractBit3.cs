using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Input integer :");
        int digit = int.Parse(Console.ReadLine());

        Console.WriteLine("bit #3 :" + (digit >> 3 & 1));
    }
}
