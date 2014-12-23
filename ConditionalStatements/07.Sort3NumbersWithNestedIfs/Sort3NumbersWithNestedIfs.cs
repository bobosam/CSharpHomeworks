using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Input first number :");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Input second number :");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Input third number :");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggest, bigger, small;

        if ((firstNumber >= secondNumber)
            &&
           (firstNumber >= thirdNumber))
        {
            biggest = firstNumber;

            if (secondNumber >= thirdNumber)
            {
                bigger = secondNumber;
                small = thirdNumber;
            }
            else
            {
                bigger = thirdNumber;
                small = secondNumber;
            }
        }

        else if ((secondNumber >= firstNumber)
                &&
                (secondNumber >= thirdNumber))
        {
            biggest = secondNumber;

            if (firstNumber >= thirdNumber)
            {
                bigger = firstNumber;
                small = thirdNumber;
            }
            else
            {
                bigger = thirdNumber;
                small = firstNumber;
            }
        }
        else
        {
            biggest = thirdNumber;

            if (firstNumber >= secondNumber)
            {
                bigger = firstNumber;
                small = secondNumber;
            }
            else
            {
                bigger = secondNumber;
                small = firstNumber;
            }
        }

        Console.WriteLine("Result :{0} {1} {2}", biggest, bigger, small);
    }
}
