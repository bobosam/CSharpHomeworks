using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Input integer :");
        int digit = int.Parse(Console.ReadLine());
        Console.Write("Input position P :");
        int position = int.Parse(Console.ReadLine());

        bool check = ((digit >> position) & 1) == 1;
        Console.WriteLine("bit @ p == 1 :" + check);
    }
}
