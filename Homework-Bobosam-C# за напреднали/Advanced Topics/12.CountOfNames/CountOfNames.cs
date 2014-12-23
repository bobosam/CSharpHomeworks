using System;

class CountOfNames
{
    static void Main()
    {
        Console.Write("Enter string of names --> ");
        string input = Console.ReadLine();
        string[] inputArea = input.Split(' ');

        Array.Sort(inputArea);
        int counter = 1;
        string letters = inputArea[0];

        for (int i = 1; i < inputArea.Length; i++)
        {
            if (inputArea[i] == letters)
            {
                counter++;
            }
            else
            {
                Console.WriteLine("{0} --> {1}", letters, counter);
                letters = inputArea[i];
                counter = 1;
            }

            if (i == inputArea.Length - 1)
            {
                Console.WriteLine("{0} --> {1}", letters, counter);
            }
        }
    }
}
