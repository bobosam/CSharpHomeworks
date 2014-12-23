using System;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Binary --> ");
        string binary = Console.ReadLine();
        long deci = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            int koef = int.Parse(Convert.ToString(binary[binary.Length - i - 1]));
            deci +=(long)(Math.Pow(2, i) * koef);
        }

        Console.WriteLine("Decimal --> {0}" , deci);
    }
}
