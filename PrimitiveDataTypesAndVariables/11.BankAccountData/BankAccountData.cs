using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("First Name:");
        string firstName = Console.ReadLine();
        Console.Write("Middle Name:");
        string middleName = Console.ReadLine();
        Console.Write("Last Name:");
        string lastName = Console.ReadLine();
        Console.Write("Balance:");
        decimal balance = decimal.Parse (Console.ReadLine());
        Console.Write("Bank name:");
        string bankName = Console.ReadLine();
        Console.Write("IBAN :");
        string iban = Console.ReadLine();
        Console.Write("Credit card number 1.");
        long creditCardNumber1 = long.Parse(Console.ReadLine());
        Console.Write("Credit card number 2.");
        long creditCardNumber2 = long.Parse(Console.ReadLine());
        Console.Write("Credit card number 3.");
        long creditCardNumber3 =long.Parse(Console.ReadLine());
    }
}
