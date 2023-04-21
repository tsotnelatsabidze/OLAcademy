using System;

class UserVerification
{
    static void Main()
    {
        string username = "myUsername";
        string password = "myPassword";
        int attempts = 0;

        while (attempts < 5)
        {
            Console.Write("Enter username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Success");
                break;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                attempts++;
            }
        }

        if (attempts == 5)
        {
            Console.WriteLine("Error: Maximum login attempts reached.");
        }
    }
}
