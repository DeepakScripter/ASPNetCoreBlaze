namespace FuelCostCalculator.Models   // Defining the namespace for the model
{
    // Defining the AgeDifferenceModel class
    public class AgeDifferenceModel
    {
        // Properties to represent the attributes of the AgeDifferenceModel
        public string FirstPersonName { get; set; }   // Name of the first person
        public int FirstPersonDob { get; set; }        // Date of birth of the first person
        public string SecondPersonName { get; set; }  // Name of the second person
        public int SecondPersonDob { get; set; }       // Date of birth of the second person
        public bool IsAgeDifference { get; set; }      // Flag indicating if an age difference is calculated
    }
}
