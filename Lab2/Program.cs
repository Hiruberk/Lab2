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
                double area = Math.Round(L * W, 2);
                double perimeter = Math.Round(2 * L + 2 * W, 2);
                double volume = Math.Round(L * W * H, 2);

                // Displays Console lines for Area, Perimeter, and Volume, where the variables are also displayed to the user
                Console.WriteLine("Area: " + area + " sqft");
                Console.WriteLine("Perimeter: " + perimeter + " ft");
                Console.WriteLine("Volume: " + volume + " cubic ft");

                Console.WriteLine("Continue? (y/n)"); // Asks the user to continue the loop or not

            } while (Console.ReadLine().ToLower() == "y"); // Breaks the loop unless "y" or "Y" is entered, this assumes that you do not want to continue unless you answer "y" or "Y"
        }
    }
}
