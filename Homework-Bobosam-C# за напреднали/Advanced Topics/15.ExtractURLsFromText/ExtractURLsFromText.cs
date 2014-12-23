using System;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.Write("Text --> ");
        string text = Console.ReadLine();
        string url;
        Console.WriteLine();

        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (4 < words[i].Length)
            {

                if (words[i].Substring(0, 4) == "http" || words[i].Substring(0, 4) == "www.")
                {
                    if (words[i].Substring(words[i].Length - 1, 1) == ".")
                    {
                        url = words[i].Substring(0, words[i].Length - 1);
                    }
                    else
                    {
                        url = words[i];
                    }

                    Console.WriteLine("URL --> {0}", url);
                }
            }
        }
        Console.WriteLine();
    }
}
