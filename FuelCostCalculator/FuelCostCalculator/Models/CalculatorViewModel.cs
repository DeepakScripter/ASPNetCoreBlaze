using System;                               // Importing the System namespace
using System.Collections.Generic;           // Importing the System.Collections.Generic namespace
using System.Linq;                          // Importing the System.Linq namespace
using System.Threading.Tasks;               // Importing the System.Threading.Tasks namespace

namespace FuelCostCalculator.Models          // Defining the namespace for the model
{
    // Defining the CalculatorViewModel class
    public class CalculatorViewModel
    {
        public FuelModel fuelModel { get; set; }                 // Property to hold FuelModel
        public AgeModel ageModel { get; set; }                   // Property to hold AgeModel
        public AgeDifferenceModel ageDifferenceModel { get; set; }  // Property to hold AgeDifferenceModel
    }
}
