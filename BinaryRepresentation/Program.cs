using System;

class Program
{
    static void Main()
    {
        /*
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryNumber = Convert.ToString(decimalNumber, 2);

        Console.WriteLine($"Binary representation of {decimalNumber}: {binaryNumber}");

        */

        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string binary = "";
        while (num > 0)
        {
            binary = (num % 2) + binary;
            num /= 2;
        }
        Console.WriteLine("The binary representation is {0}", binary);
    }

}
