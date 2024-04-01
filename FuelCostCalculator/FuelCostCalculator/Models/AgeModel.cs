using System;                               // Importing the System namespace
using System.ComponentModel.DataAnnotations; // Importing the System.ComponentModel.DataAnnotations namespace

namespace FuelCostCalculator.Models          // Defining the namespace for the model
{
    // Defining the AgeModel class
    public class AgeModel
    {
        [Required]                             // Specifying that DateOfBirth is required
        public DateTime? DateOfBirth { get; set; }  // Property to represent the date of birth of a person

        [Required]                             // Specifying that AgeAtTheDateOf is required
        [DataType(DataType.Date)]              // Specifying the data type of AgeAtTheDateOf
        public DateTime AgeAtTheDateOf { get; set; } // Property to represent the date at which age is calculated

        // Properties to represent different units of age
        public int AgeInMonths { get; set; }    // Age in months
        public int AgeInWeeks { get; set; }     // Age in weeks
        public int AgeInHours { get; set; }     // Age in hours
        public int AgeInMinutes { get; set; }   // Age in minutes
        public int AgeInSeconds { get; set; }   // Age in seconds

        public bool IsAgeCalculator { get; set; }   // Flag indicating if age calculation is performed
        public string TotalAges { get; set; }       // String representation of total ages
    }
}
