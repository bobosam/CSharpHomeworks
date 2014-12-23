using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Input four-digit number :");
        string abcd = Console.ReadLine();

        string digitA = abcd.Substring(0, 1);
        string digitB = abcd.Substring(1, 1);
        string digitC = abcd.Substring(2, 1);
        string digitD = abcd.Substring(3, 1);
        int valueA = int.Parse(digitA);
        int valueB = int.Parse(digitB);
        int valueC = int.Parse(digitC);
        int valueD = int.Parse(digitD);

        int sum = valueA + valueB + valueC + valueD;
        Console.WriteLine("sum of digits =" + sum);
        Console.WriteLine("reversed :" + digitD + digitC + digitB + digitA);
        Console.WriteLine("last digit in front :" + digitD + digitA + digitB + digitC);
        Console.WriteLine("second end third digits exchanged :" + digitA + digitC + digitB + digitD);
    }
}
