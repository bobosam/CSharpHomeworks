using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type :");
        Console.WriteLine("1 --> int\n2 --> double\n3 --> string");
        string choose = Console.ReadLine();

        switch (choose)
        {
            case "1":
                Console.Write("Please enter a integer :");
                int intNumber = int.Parse(Console.ReadLine());
                intNumber++;
                Console.WriteLine(intNumber);
                break;

            case "2":
                Console.Write("Please enter a double :");
                double doubleNumber = double.Parse(Console.ReadLine());
                doubleNumber++;
                Console.WriteLine(doubleNumber);
                break;

            case "3":
                Console.Write("Please enter a string :");
                string innString = Console.ReadLine(); 
                Console.WriteLine(innString + "*");
                break;

            default:
                Console.WriteLine("Not a valid choose.");
                break;
        }
    }
}
