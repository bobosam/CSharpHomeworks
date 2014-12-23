using System;
using System.Collections.Generic;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        List<string> https = new List<string>();
        List<int> counters = new List<int>();
        List<double> times = new List<double>();
        int counter = 1;

        while (true)
        {
            Console.Write("Input string --> ");
            string input = Console.ReadLine();
            string[] inn = input.Split(' ');
            double time = double.Parse(inn[3]);

            if (0 == https.Count)
            {
                https.Add(inn[2]);
                counters.Add(counter);
                times.Add(time);
            }
            else
            {
                string check = "newHttp";

                for (int i = 0; i < https.Count; i++)
                {
                    if (inn[2] == https[i])
                    {
                        counters[i]++;
                        times[i] += time;
                        check = "oldHttp";
                    }
                }

                if ("newHttp" == check)
                {
                    https.Add(inn[2]);
                    counters.Add(counter);
                    times.Add(time);
                }
            }

            for (int i = 0; i < https.Count; i++)
            {
                double averageTime = times[i] / counters[i];
                Console.WriteLine("{0} --> {1}" , https[i] , averageTime);
            }

            Console.WriteLine();
        }
    }
}
