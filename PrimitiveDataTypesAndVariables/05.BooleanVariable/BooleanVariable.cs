using System;

class BooleanVariable
{
    static void Main()
    {
        Console.WriteLine("Enter your gender: male or female");
        string yourGender = Console.ReadLine();
        int result = String.Compare(yourGender, "female");
        bool isFemale = (result == 0);
        Console.WriteLine("\"You are female.\" This is " + isFemale);
    }
}
