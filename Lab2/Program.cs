using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            bool again = true;

            do
            {
                Console.WriteLine("Enter Length (ft): ");
                double L = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width (ft): ");
                double w = double.Parse(Console.ReadLine());
                double area = L * w;
                double perimeter = 2 * L + 2 * w;
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                again = false;
            } while (again == true);
        }
    }
}
