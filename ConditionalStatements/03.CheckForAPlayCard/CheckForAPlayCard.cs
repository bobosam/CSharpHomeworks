using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Input card sign :");
        string inString = Console.ReadLine();
        bool check = false;

        for (int i = 2; i < 11; i++)
        {
            string loopDigit = Convert.ToString(i);
            if (loopDigit == inString)
            {
                Console.WriteLine("Valid card sign? Yes");
                check = true;
            }
        }

        if (inString == "J" || inString == "Q" || inString == "K" || inString == "A")
        {
            Console.WriteLine("Valid card sign? Yes");
            check = true;
        }

        if (check == false)
        {
            Console.WriteLine("Valid card sign? No");
        }
    }
}
