using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace totalCostofFuel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables for user input values
            double inputCost;
            double inputLiters;

            // Starting the console app with a welcome message
            WriteLine("Welcome to the fuel cost calculator. ");
            WriteLine("Made by Nelli Holopainen");
            WriteLine("=============\n");

            // Ask the user over and over again until the value is valid
            do {

                // Promt the user for the amount of fuel
                WriteLine("Enter the amount of liters of fuel filled in the car: ");
                double.TryParse(ReadLine(), out inputLiters);

                if (inputLiters <= 0 )
                {
                    WriteLine("Error! Negative values or letters not allowed.");
                }

            } while (inputLiters <= 0);

            // Ask the user over and over again until the value is valid
            do
            {
                // Promt the user for the cost of fuel
                WriteLine("Enter the cost in dollars and cents (eg. 20.77): ");
                double.TryParse(ReadLine(), out inputCost);

                if (inputCost <= 0)
                {
                    WriteLine("Error! Negative values or letters not allowed.");
                }

            } while (inputCost <= 0);

            // New fuel object
            Fuel fuel = new Fuel();

            // Assign the validated values to object data fields
            fuel.liters = inputLiters;
            fuel.cost = inputCost;

            // Print the result using the tostring method
            WriteLine("=============");
            WriteLine("The result:");
            WriteLine(fuel.ToString());

            WriteLine("\nThank you for using fuel cost calculator! Press any key to exit.");
            ReadLine();

        }
    }
}
