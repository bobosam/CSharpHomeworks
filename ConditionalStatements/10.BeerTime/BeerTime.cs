using System;
using System.Globalization;

    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Please enter time h:mm tt");
            string inputTime = Console.ReadLine();
            string format = "h:mm tt";
            DateTime startTime =DateTime.ParseExact ("1:00 PM" , format ,CultureInfo.InvariantCulture);
            DateTime endTime = DateTime.ParseExact("3:00 AM", format, CultureInfo.InvariantCulture);

            DateTime checkTime;
            if (DateTime.TryParseExact( inputTime , format ,CultureInfo.InvariantCulture , DateTimeStyles.None , out checkTime))
            {
                if (checkTime.Hour >= endTime.Hour && checkTime.Hour < startTime.Hour)
                {
                    Console.WriteLine("non-beer time");
                }
                else
                {
                    Console.WriteLine("beer time");
                }
            }
            else
            {
                Console.WriteLine("Not a valid time");
            }
        }
    }
