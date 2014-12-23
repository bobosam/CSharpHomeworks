using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotedStringA = "The \"use\" of quotations causes difficulties.";
        string quotedStringB = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotedStringA);
        Console.WriteLine(quotedStringB);
    }
}
