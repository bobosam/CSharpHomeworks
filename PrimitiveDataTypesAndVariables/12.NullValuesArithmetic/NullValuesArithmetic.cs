using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);

        a += 5;
        b += 3.55; 
        Console.WriteLine("Printing the nullable variables: a: {0} b: {1}", a, b);
    }
}
