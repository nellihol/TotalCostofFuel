using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalCostofFuel
{
    class Fuel
    {
        // The fuel variables
        public double liters { get; set; }
        public double cost { get; set; }

        private double totalCost;

        // Calculate the total cost of fuel 
        public double calculateCost(double _cost, double _liters) {
            totalCost = _cost * _liters;
            return totalCost;
        }

        // Return a message of the calculated values 
        public new string ToString() {
            // Print the message with the variable values  and use the calculation method to get the total amount
            return ("Number of liters of fuel " + liters + " l. Cost of fuel: $"+ cost + ". Total cost: $"+ calculateCost(liters, cost));
        }
    }
}
