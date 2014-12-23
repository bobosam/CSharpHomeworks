using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Input iteger :");
        string integer = Console.ReadLine();
        bool check = false;

        int stringLenght = integer.Length;
        string digit = integer.Substring(stringLenght - 3, 1);

        if(digit == "7")
        {
            check = true;
        }

        Console.WriteLine("Third digit 7? " + check);
    }
}
