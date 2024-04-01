using FuelCostCalculator.Models;  // Importing the necessary model
using Microsoft.AspNetCore.Mvc;
using System;

namespace FuelCostCalculator.Controllers
{
    // Define the FuelController class inheriting from Controller
    public class FuelController : Controller
    {
        // Define the Index action method with parameters model and reset
        public IActionResult Index(CalculatorViewModel model, bool reset)
        {
            // Region for Fuel Calculation logic
            #region Fuel Calculation
            // Check if reset is true or fuelModel is null, then initialize fuelModel
            if (reset || model.fuelModel == null)
                model.fuelModel = new FuelModel();

            // Check if fuelModel and its properties are valid for calculation
            if (model.fuelModel != null && model.fuelModel.DailyDistenceTravel > 0 && model.fuelModel.Mileage > 0 && model.fuelModel.FuelCost > 0)
            {
                const int month = 30;
                const int yearDay = 365;
                // Calculate DailyFuelCost, MonthlyFuelCost, and YearlyFuelCost
                model.fuelModel.DailyFuelCost = Math.Round(model.fuelModel.DailyDistenceTravel.Value / model.fuelModel.Mileage.Value * model.fuelModel.FuelCost.Value, 2);
                model.fuelModel.MonthlyFuelCost = Math.Round(model.fuelModel.DailyFuelCost * month, 2);
                model.fuelModel.YearlyFuelCost = Math.Round(model.fuelModel.DailyFuelCost * yearDay, 2);
                model.fuelModel.IsCalculated = true; // Set IsCalculated flag to true
            }
            #endregion

            // Region for Age Calculation logic
            #region Age Calculation
            // Check if reset is true or ageModel is null, then initialize ageModel
            if (reset || model.ageModel == null)
                model.ageModel = new AgeModel() { AgeAtTheDateOf = DateTime.Now };

            // Check if ageModel and its properties are valid for calculation
            if (model.ageModel != null && model.ageModel.DateOfBirth != null && model.ageModel.AgeAtTheDateOf != null)
            {
                DateTime birth = new DateTime(model.ageModel.DateOfBirth.Value.Year, model.ageModel.DateOfBirth.Value.Month, model.ageModel.DateOfBirth.Value.Day);
                TimeSpan span = model.ageModel.AgeAtTheDateOf - birth;
                DateTime age = DateTime.MinValue + span;
                // Make adjustment due to MinValue equalling 1/1/1int years = age.Year - 1;
                int month = age.Month - 1;
                int days = birth.Day == 31 ? age.Day : age.Day - 1;
                // Format the TotalAges string with years, months, and days
                model.ageModel.TotalAges = string.Format("{0} Years , {1} Months , {2} Days", age.Year - 1, month, days);
                model.ageModel.AgeInMonths = (int)(span.Days / 30.436875); // Calculate AgeInMonths
                model.ageModel.AgeInWeeks = (int)(span.Days / 7); // Calculate AgeInWeeks
                model.ageModel.AgeInHours = (int)span.TotalHours; // Calculate AgeInHours
                model.ageModel.AgeInMinutes = (int)span.TotalMinutes; // Calculate AgeInMinutes
                model.ageModel.AgeInSeconds = (int)span.TotalSeconds; // Calculate AgeInSeconds
                model.ageModel.IsAgeCalculator = age.Year - 1 > 0 ? true : false; // Check if AgeCalculator is valid
            }
            else
            {
                model.ageModel.IsAgeCalculator = false; // Set IsAgeCalculator flag to false
            }
            #endregion

            // Return the view with the updated model
            return View(model);
        }
    }
}
