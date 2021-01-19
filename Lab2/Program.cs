using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");

            // Do-While is used for the continue y/n prompt
            do
            {   // Outputs Enter Length (ft): then stores that value in L
                Console.WriteLine("Enter Length (ft): ");
                double L = double.Parse(Console.ReadLine());//The readline has to be converted to double, so it can accept decimals and be used in the formulas below

                // Outputs Enter Width (ft): then stores that value in W
                Console.WriteLine("Enter Width (ft): ");
                double W = double.Parse(Console.ReadLine());

                // Outputs Enter Height (ft): then stores that value in H
                Console.WriteLine("Enter Height (ft): ");
                double H = double.Parse(Console.ReadLine());

                // Formulas to calculate Area, Perimeter, and Volume where they are assigned double to allow for decimal places.
                double area = L * W;
                double perimeter = 2 * L + 2 * W;
                double volume = L * W * H;

                // Displays Console lines for Area, Perimeter, and Volume, where the variables are also displayed to the user
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue? (y/n)"); // Asks the user to continue the loop or not

            } while (Console.ReadLine().ToLower() == "y"); // This assumes as long as they do not say "Y" or "y" it will continue to run
        }
    }
}
