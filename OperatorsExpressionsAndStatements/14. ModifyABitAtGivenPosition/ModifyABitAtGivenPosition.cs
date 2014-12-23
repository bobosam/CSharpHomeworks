using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Input integer N :");
        int digitIn = int.Parse(Console.ReadLine());
        Console.Write("Input position P :");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Input value V 0 or 1 :");
        int value = int.Parse(Console.ReadLine());
        int digitOut = 0;

        //set bit to one
        if (value == 1)
        {
            digitOut = digitIn | (1 << position);
        }
        else
        //set bit to zero
        {
            digitOut = digitIn & (~(1 << position));
        }

        string digitOutBin = Convert.ToString(digitOut,2);
        string digitInBin = Convert.ToString(digitIn, 2);

        Console.WriteLine("binary representation of n :" + digitInBin);
        Console.WriteLine("binary result : " + digitOutBin);
        Console.WriteLine("result :" + digitOut);
    }
}
