using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Input integer :");
        int integerN = int.Parse(Console.ReadLine());
        bool check = false;

        //divide by 7 * 5 = 35
        if (integerN % 35 == 0)
        {
            check = true;
        }

        Console.WriteLine("Divided by 7 and 5? " + check);
    }
}
