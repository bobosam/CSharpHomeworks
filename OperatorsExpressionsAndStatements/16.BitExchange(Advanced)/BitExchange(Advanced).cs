using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        
        uint digitIn;
        bool isNum;

        do
        {
            Console.Write("Input digit N :");
            //check for out of range
            isNum = uint.TryParse(Console.ReadLine(), out digitIn);
            if (false == isNum)
            {
                Console.WriteLine("out of range");
            }

        } while (false == isNum);

        Console.Write("Input position P :");
        int positionP = int.Parse(Console.ReadLine());
        Console.Write("Input position Q :");
        int positionQ = int.Parse(Console.ReadLine());
        Console.Write("Input number of bits K :");
        int numberK = int.Parse(Console.ReadLine());

        //check for overlapping
        if ( Math.Abs(positionQ - positionP) < numberK )
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            //check for out of range
            if ((positionP + numberK) > 32 || (positionQ + numberK) > 32 || positionQ < 0 || positionP < 0 || numberK < 0)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                uint maskRead = 0;

                if (positionP > positionQ)
                {
                    //change value
                    positionP = positionP + positionQ;
                    positionQ = positionP - positionQ;
                    positionP = positionP - positionQ;
                }

                for (int i = 0; i < numberK; i++)
                {
                    // Create mask with length k, e.g. 111
                    maskRead += (uint)Math.Pow(2, i);
                }

                //maskRead go to position
                uint mask1 = maskRead << positionP;
                uint mask2 = maskRead << positionQ;

                //read bits
                uint digit1 = digitIn & mask1;
                uint digit1Move = digit1 <<(positionQ - positionP);
                uint digit2 = digitIn & mask2;
                uint digit2Move = digit2 >> (positionQ - positionP);

                //mask for change
                uint mask = digit1Move | digit2Move;

                //set to zero bits
                uint maskZero = ~(mask1 | mask2);
                uint digitZero = digitIn & maskZero;

                //final action for result
                uint digitOut = digitZero | mask;

                //binary representation of digit
                string digitInBin = Convert.ToString(digitIn, 2);
                string digitOutBin = Convert.ToString(digitOut, 2);

                Console.WriteLine("binary representation of N :" + digitInBin);
                Console.WriteLine("binary result :" + digitOutBin);
                Console.WriteLine("result :" + digitOut);
            }
        }
    }
}
