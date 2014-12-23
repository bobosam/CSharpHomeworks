using System;

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        bool check;
        long deci, reminder;
        string temp = string.Empty;
        string hex = string.Empty;

        do
        {
            Console.Write("Decimal --> ");
            check = long.TryParse(Console.ReadLine(), out deci);
        } while (false == check);

        if (0 != deci)
        {
            while (0 < deci)
            {
                reminder = deci % 16;
                deci = deci / 16;

                switch (reminder)
                {
                    case 10:
                        temp = "A";
                        break;

                    case 11:
                        temp = "B";
                        break;

                    case 12:
                        temp = "C";
                        break;

                    case 13:
                        temp = "D";
                        break;

                    case 14:
                        temp = "E";
                        break;

                    case 15:
                        temp = "F";
                        break;

                    default:
                        temp = Convert.ToString(reminder);
                        break;
                }
                hex = temp + hex;
            }
        }
        else
        {
            hex = "0";
        }

        Console.WriteLine("Hexadecimal --> {0}", hex);

    }
}
