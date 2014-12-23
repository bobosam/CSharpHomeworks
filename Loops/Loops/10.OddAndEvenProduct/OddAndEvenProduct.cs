using System;

class Program
{
    static void Main()
    {
        int oddSum = 1;
        int evenSum = 1;
        Console.Write("String products --> ");
        string produkts = Console.ReadLine();

        string[] produkt = produkts.Split(' ');
        int[] valueProdukt = new int[produkt.Length];

        for (int i = 0; i < produkt.Length; i++)
        {
            valueProdukt[i] = int.Parse(produkt[i]);

            if (0 == i %2)
            {
                oddSum *= valueProdukt[i];
            }
            else
            {
                evenSum *= valueProdukt[i];
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product ={0}",oddSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product ={0}",oddSum);
            Console.WriteLine("even_product ={0}", evenSum);
        }
    }
}
