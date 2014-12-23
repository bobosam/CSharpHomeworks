using System;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        for (int i = 0; i <= 255; i++)
        {
            char c = (char)i;
            Console.WriteLine("{0} {1}", i, c);
        }
    }
}
