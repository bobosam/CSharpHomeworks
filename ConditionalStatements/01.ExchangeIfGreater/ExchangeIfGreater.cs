using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Input first element A=");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Input second element B=");
        double second = double.Parse(Console.ReadLine());

        double greater = Math.Max(first, second);

        if (greater == first) first = second;

        Console.WriteLine("result :{0} {1}",first, greater);
    }
}
