using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Input integer :");
        int digit = int.Parse(Console.ReadLine());
        Console.Write("Input index p :");
        int indexP = int.Parse(Console.ReadLine());

        Console.WriteLine("bit @ p : " + ((digit >> indexP) & 1));
    }
}
