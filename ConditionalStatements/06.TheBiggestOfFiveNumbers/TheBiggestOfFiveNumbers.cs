using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        double[] number = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Input number :");
            number[i] = double.Parse(Console.ReadLine());
        }

        double firstBigger = number[0];

        if (number[0] < number[1])
        {
            firstBigger = number[1]; 
        }

        double secondBigger = number[2];

        if (number[2] < number[3])
        {
            secondBigger = number[3];
        }

        double bigger = firstBigger;

        if (firstBigger < secondBigger)
        {
            bigger = secondBigger;
        }

        double biggest = bigger;

        if (bigger < number[4])
        {
            biggest = number[4];
        }

        Console.WriteLine("biggest ={0}" , biggest);
    }
}
