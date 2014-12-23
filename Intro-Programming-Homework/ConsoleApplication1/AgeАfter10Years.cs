using System;

class AgeАfter10Years
{
    static void Main()
    {
        Console.WriteLine("Дата на раждане");
        int inputDate = int.Parse(Console.ReadLine());
        Console.WriteLine("Месец");
        int inputMonth = int.Parse(Console.ReadLine());
        Console.WriteLine("Година на раждане");
        int inputYear = int.Parse(Console.ReadLine());

        DateTime myBirthdey = new DateTime(inputYear, inputMonth, inputDate);
        var myAge = DateTime.Now.Year - myBirthdey.Year;

        Console.WriteLine("Вашата възраст е: " + myAge);
        Console.WriteLine("След 10години ще сте на:" + (myAge + 10));
    }
}
