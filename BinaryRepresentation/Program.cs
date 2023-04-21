using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"Binary representation of {decimalNumber}: {binaryNumber}");
    }
}
