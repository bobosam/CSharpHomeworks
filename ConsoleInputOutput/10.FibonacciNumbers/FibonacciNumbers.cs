using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Input count N:");
        int counter = int.Parse(Console.ReadLine());
        int firstElement = 0;
        int secondElement = 1;

        if (counter == 1)
        {
            Console.WriteLine(firstElement);
        }
        else
        {
            if (counter ==2)
            {
                Console.WriteLine("{0} {1}", firstElement, secondElement);
            }
            else
            {
                Console.Write("{0} {1}", firstElement, secondElement);
                for (int i = 2; i < counter; i++)
                {
                    int thirdElement = firstElement + secondElement;
                    Console.Write(" {0}", thirdElement);
                    firstElement = secondElement;
                    secondElement = thirdElement;

                    if (i == counter - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
