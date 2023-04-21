

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = Calculate(5, 10);
            Console.WriteLine("Area: " + area);

            double volume = Calculate(5, 10, 5);
            Console.WriteLine("Volume: " + volume);
        }
        
        static double Calculate(double length, double width)
        {
            return length * width;
        }

        static double Calculate(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
