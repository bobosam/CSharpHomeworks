using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("weight :");
        double weight = double.Parse(Console.ReadLine());

        double moonWeight = weight * 0.17;

        Console.WriteLine("weight on the moon :" + moonWeight);
    }
}
