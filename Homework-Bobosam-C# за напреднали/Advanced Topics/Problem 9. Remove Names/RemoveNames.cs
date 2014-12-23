using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        Console.Write("First list --> ");
        string firstString = Console.ReadLine();
        Console.Write("Second list --> ");
        string secondString = Console.ReadLine();

        string[] firstArea = firstString.Split(' ');
        string[] secondArea = secondString.Split(' ');

        List<string> first = new List<string>();

        for (int i = 0; i < firstArea.Length; i++)
        {
            first.Add(firstArea[i]);
        }

        for (int i = 0; i < firstArea.Length; i++)
        {
            for (int j = 0; j < secondArea.Length; j++)
            {
                first.Remove(secondArea[j]);
            }
        }

        Console.WriteLine();

        foreach (var name in first)
        {
            Console.Write("{0} ", name);
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
