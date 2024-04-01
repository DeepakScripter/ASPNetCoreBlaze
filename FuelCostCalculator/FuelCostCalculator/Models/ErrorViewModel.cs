using System;   // Importing the System namespace

namespace FuelCostCalculator.Models   // Defining the namespace for the model
{
    // Defining the ErrorViewModel class
    public class ErrorViewModel
    {
        public string RequestId { get; set; }    // Property to hold the request ID

        // Property to determine if the request ID should be shown
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
