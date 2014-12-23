using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter first date dd.MM.yyyy -->");
        string first = Console.ReadLine();
        Console.Write("Enter second date dd.MM.yyyy -->");
        string second = Console.ReadLine();
        string format = "d.M.yyyy";

        DateTime firstDate = DateTime.ParseExact(first, format , CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(second , format , CultureInfo.InvariantCulture);

        TimeSpan time = secondDate - firstDate;
        Console.WriteLine(time.Days);
    }
}
