using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        string[] cards = { "2","3","4","5","6","7","8","9","10","J","Q","K","A" };
        char[] suits = { '\u2663','\u2666','\u2665','\u2660' };

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (8 != i)
                {
                    Console.Write(" {0}{1} ", cards[i], suits[j]);
                }
                else
                {
                    Console.Write("{0}{1} ", cards[i],suits[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
