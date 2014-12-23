using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Input digit N :");
        uint digitIn = uint.Parse(Console.ReadLine());

        //create mask
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;
        uint digit1 = digitIn & mask1;
        uint digit1Move = digit1 << 21;
        uint digit2 = digitIn & mask2;
        uint digit2Move = digit2 >> 21;
        uint mask = digit1Move | digit2Move;

        //set bits to zero
        uint maskZero = ~(mask1 | mask2);
        uint digitZero = digitIn & maskZero;

        //change bits
        uint digitOut = digitZero | mask;

        string digitInBin = Convert.ToString(digitIn, 2);
        string digitOutBin = Convert.ToString(digitOut, 2);

        Console.WriteLine("binary representation of N :" + digitInBin);
        Console.WriteLine("binary result :" + digitOutBin);
        Console.WriteLine("result :" + digitOut);
    }
}
