using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        bool check;
        int deci, remainder;
        string binary = string.Empty;

        do
        {
            Console.Write("Decimal --> ");
            check = int.TryParse(Console.ReadLine(), out deci);
            
        } while (false==check);

        if (0 != deci)
        {
            while (0 < deci)
            {
                remainder = deci % 2;
                deci = deci / 2;

                binary = Convert.ToString(remainder) + binary;
            }
        }
        else
        {
            binary = "0";
        }

        Console.WriteLine("Binary --> {0}" , binary);
    }
}
