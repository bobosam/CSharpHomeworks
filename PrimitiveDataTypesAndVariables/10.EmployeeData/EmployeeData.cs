using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("First Name:");
        string firstName = Console.ReadLine();
        Console.Write("Last Name:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        byte age = byte.Parse (Console.ReadLine());
        Console.Write("Gender? m or f:");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Personal ID Number :");
        long personalIDnumber = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number :");
        int uniqueEmployeeNumber =int.Parse( Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("First Name:" + firstName);
        Console.WriteLine("Last Name:" + lastName);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Gender:" + gender);
        Console.WriteLine("Personal ID Number:"+ personalIDnumber);
        Console.WriteLine("Unique employee number:" + uniqueEmployeeNumber);
    }
}
