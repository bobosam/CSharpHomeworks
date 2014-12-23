using System;

class ZeroSubset
{
    static void Main()
    {
        bool check = true;
        bool checksum = false;
        int sum = 0;
        int[] number = new int[5];
        int[] result = new int[5];
        
        do
        {
            Console.Write("Input string numbers: ");
            string input = Console.ReadLine();

            string[] numbersString = input.Split(' ');

            if (5 != numbersString.Length)
            {
                check = false;
                continue;
            }

            for (int i = 0; i < numbersString.Length; i++)
            {
                bool res = int.TryParse(numbersString[i], out number[i]);
                if (res == false)
                {
                    check = false;
                }
            }
        }
        while (check == false );

        for (int i = 1; i < 32; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int koef = (i & (1 << j)) >> j;
                result[j] = number[j] * koef;
                sum += result[j];
            }

            if (sum == 0)
            {
                int count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if ( result[j] == number[j])
                    {
                        if (0 == count)
                        {
                            Console.Write("{0}", result[j]);
                            count ++;
                        }
                        else
                        {
                            Console.Write(" + {0}",result[j]);
                        }
                    }
                }
                checksum = true;
                Console.WriteLine("=0");
            }
            sum = 0;
        }
        if (checksum == false)
        {
            Console.WriteLine("no zero subset");
        }
    }
}
