using System;

class MatrixOfNumbers
{
    static void Main()
    {
        bool check;
        int numberN;

        do
        {
            Console.Write("N -->");
            check = int.TryParse(Console.ReadLine(), out numberN);
        } while (false == check);

        for (int i = 0; i < numberN; i++)
        {

            for (int j = i+1; j <= i + numberN; j++)
            {
                Console.Write("{0,3}", j);
            }

            Console.WriteLine();
        }
    }
}
