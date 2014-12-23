using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Hexadecimal --> ");
        string hexa = Console.ReadLine();
        long deci = 0;
        long temp;

        for (int i = 0; i < hexa.Length; i++)
        {
            char element = hexa[hexa.Length - i - 1];

            switch (element)
            {
                case 'A':
                case 'a':
                    temp = 10;
                    break;

                case 'B':
                case 'b':
                    temp = 11;
                    break;

                case 'C':
                case 'c':
                    temp = 12;
                    break;

                case 'D':
                case 'd':
                    temp = 13;
                    break;

                case 'E':
                case 'e':
                    temp = 14;
                    break;
                case 'F':
                case 'f':
                    temp = 15;
                    break;

                default: temp = int.Parse(Convert.ToString(element));
                    break;
            }

            deci += temp * (long)(Math.Pow(16, i));
        }

        Console.WriteLine("Decimal --> {0}", deci);

    }
}
