using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Input integer :");
        int digit = int.Parse(Console.ReadLine());
        bool check = true;

        if (digit <= 1)
        {
            check = false;
        }
        else
        {
            int lenght = (int)(Math.Sqrt(digit));
            for (int i = 2; i <= lenght; i++)
            {
                if (digit % i == 0)
                {
                    check = false;
                }
            }
        }

        Console.WriteLine("Prime :" + check);
    }
}
