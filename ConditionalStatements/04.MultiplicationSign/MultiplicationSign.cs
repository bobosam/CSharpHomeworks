using System;

class MultiplicationSign
{
    static void Main()
    {
        int counter = 0;
        bool checkZero = false;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Input number :");
            double number = double.Parse(Console.ReadLine());

            if (0 > number)
            {
                counter++;
            }
            else if (0 == number)
            {
                checkZero = true;
            }
        }

        int tmp = counter % 2;

        if (false != checkZero)
        {
            Console.WriteLine("result :0");
        }
        else if (0 == tmp)
        {
            Console.WriteLine("result : +"); 
        }
        else
        {
            Console.WriteLine("result : -");
        }
    }
}
