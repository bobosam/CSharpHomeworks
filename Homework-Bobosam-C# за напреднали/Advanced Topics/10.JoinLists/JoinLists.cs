using System;
using System.Collections.Generic;

class JoinLists
{
    static void Main()
    {
        Console.Write("First list --> ");
        string firstString =  Console.ReadLine();
        Console.Write("Second list --> ");
        string secondString = Console.ReadLine();

        string[] firstArea = firstString.Split(' ');
        string[] secondArea = secondString.Split(' ');

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < firstArea.Length; i++)
        {
            firstList.Add(int.Parse(firstArea[i]));
        }

        for (int i = 0; i < secondArea.Length; i++)
        {
            secondList.Add(int.Parse(secondArea[i])); 
        }

        firstList.AddRange(secondList);
        firstList.Sort();

        for (int i = 0; i < firstList.Count - 1; i++)
        {
            while (firstList[i] == firstList[i+1])
            {
                firstList.Remove(firstList[i + 1]);
            }
        }

        foreach (var element in firstList)
        {
            Console.Write("{0} ", element);
        }

        Console.WriteLine();
    }
}
