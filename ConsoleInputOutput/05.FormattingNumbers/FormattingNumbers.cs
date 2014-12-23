using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Input first number a:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Input second number b:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Input third number c:");
        double thirdNumber = double.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(firstNumber, 2).PadLeft(10,'0');
        Console.Write("|{0,-10:X}|{1}|", firstNumber , binaryNumber);

        bool checkSecondNumber = Convert.ToString(secondNumber).IndexOf(".") > 0;
        Console.Write(checkSecondNumber ? "{0,10:f2}|" : "{0,10}|", secondNumber);

        bool checkThirdNumber = Convert.ToString(thirdNumber).IndexOf(".") > 0;
        Console.WriteLine(checkThirdNumber ? "{0,-10:f3}|" : "{0,-10}|" , thirdNumber );

    }
}
