using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Please enter your number :");
        int number = int.Parse(Console.ReadLine());

        string[] words = {"zero" , "one", "two" , "three" , "four" , "five" , "six" ,"seven" , "eight" , "nine" ,
                          "ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen" };

        string[] words10 = { "0", "0", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (20 > number)
        {
            Console.WriteLine("number as words: {0}",words[number]);
        }

        else if (100 > number)
        {
            int element10 = number /10;
            int element = number % 10;

            if (0 != element)
            {
                Console.WriteLine("number as words: {0} {1}", words10[element10], words[element]);
            }
            else
            {
                Console.WriteLine("number as words: {0}", words10[element10]);
            }
        }

        else if (1000 > number)
        {
            int element100 = number / 100;
            int element10 = number % 100;

            if (0 == element10)
            {
                Console.WriteLine("number as words: {0} hundred", words[element100]);
            }

            if (20 > element10)
            {
                Console.WriteLine("number as words: {0} hundred and {1}", words[element100], words[element10]);
            }
            else
            {
                int newelement10 = (number / 10) % 10;
                int element = number % 10;

                if (0 != element)
                {
                    Console.WriteLine("number as words: {0} hundred and {1} {2}", words[element100], words10[newelement10], words[element]);
                }
                else
                {
                    Console.WriteLine("number as words: {0} hundred and {1}", words[element100], words10[newelement10]);   
                }
            }
        }
    }
}
