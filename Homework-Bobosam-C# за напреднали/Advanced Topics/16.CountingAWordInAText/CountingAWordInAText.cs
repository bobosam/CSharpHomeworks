using System;
using System.Globalization;
using System.IO;

class CountingAWordInAText
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        Console.Write("Word --> ");
        string word = Console.ReadLine();
        Console.Write("Text --> ");
        string text = Console.ReadLine();
        int counter = 0;
        bool check = true;

        string[] words = text.Split(' ', ',', '.','"','?','!','/','@',':','(',')');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == word.Length)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    string tmpWord = word.Substring(j,1);
                    string tmpText = words[i].Substring(j,1);
                    if ( tmpText.ToUpper() != tmpWord.ToUpper())
                    {
                        check = false;
                    }
                }

                if (true == check)
                {
                    counter++;
                }

                check = true;
            }
        }

        Console.WriteLine("{0} -- > {1}", word, counter);


    }
}
