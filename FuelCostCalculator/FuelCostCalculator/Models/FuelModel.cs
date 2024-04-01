using System;   // Importing the System namespace
using System.Collections.Generic;   // Importing the System.Collections.Generic namespace
using System.Linq;  // Importing the System.Linq namespace
using System.Threading.Tasks;   // Importing the System.Threading.Tasks namespace

namespace FuelCostCalculator.Models   // Defining the namespace for the model
{
    // Defining the FuelModel class
    public class FuelModel
    {
        public decimal? DailyDistenceTravel { get; set; }   // Property to represent daily distance traveled
        public decimal? Mileage { get; set; }   // Property to represent mileage
        public decimal? FuelCost { get; set; }   // Property to represent fuel cost
        public decimal DailyFuelCost { get; set; }   // Property to represent daily fuel cost
        public decimal MonthlyFuelCost { get; set; }   // Property to represent monthly fuel cost
        public decimal YearlyFuelCost { get; set; }   // Property to represent yearly fuel cost
        public bool IsCalculated { get; set; }   // Flag indicating if fuel cost is calculated
        public bool IsFuelCalculator { get; set; }   // Flag indicating if fuel calculator is active
    }
}
