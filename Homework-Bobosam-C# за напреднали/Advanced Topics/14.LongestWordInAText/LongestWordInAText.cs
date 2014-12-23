using System;

class LongestWordInAText
{
    static void Main()
    {
        Console.Write("Text --> ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ','.');
        string maxWord = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > maxWord.Length)
            {
                maxWord = words[i];
            }
        }

        Console.WriteLine("Longest word --> {0}" , maxWord);
        Console.WriteLine();
    }
}
