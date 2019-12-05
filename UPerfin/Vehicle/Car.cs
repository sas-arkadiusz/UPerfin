using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Vehicle
{
    class Car
    {
        /*
         * Possible keys: annualMaintenanceCosts, monthlyMaintenanceCosts, dailyMaintenanceCosts, maintenanceCostsByKilometers
         */
        public virtual Dictionary<string, decimal> CalculateMaintenanceCosts(VehicleInformation vehicle)
        {
            Dictionary<string, decimal> carMaintenance = new Dictionary<string, decimal>();

            int numberOfYears = DateTime.Now.Year - vehicle.PurchaseYear;
            int numberOfKilometers = vehicle.MileageCurrent - vehicle.MileageOnPurchase;
            decimal vehicleImpairment = vehicle.PurchaseCost - vehicle.ValueCurrent;

            // Calculate values that should be displayed in the Report
            double averageAnnualMileage = numberOfKilometers / numberOfYears;
            decimal averageAnnualImpairment = vehicleImpairment / numberOfYears;

            // Calculate costs of the Vehicle maintenance
            decimal annualMaintenanceCosts =
                averageAnnualImpairment +
                (vehicle.FuelCosts * 12) +
                vehicle.InsuranceCosts +
                (vehicle.CarWashCosts * 12) +
                vehicle.ServiceCosts +
                (vehicle.ParkingCosts * 12) +
                (vehicle.OtherCosts * 12);

            carMaintenance.Add("annualMaintenanceCosts", annualMaintenanceCosts);
            carMaintenance.Add("monthlyMaintenanceCosts", annualMaintenanceCosts / 12);
            carMaintenance.Add("dailyMaintenanceCosts", annualMaintenanceCosts / 365);
            carMaintenance.Add("maintenanceCostsByKilometers", (annualMaintenanceCosts * numberOfYears) / numberOfKilometers);
            return carMaintenance;
        }

        public string GenerateFormattedReport(Dictionary<string, decimal> maintenanceCosts)
        {
            return "Maintenance Costs Report \n\n"
            + "Annualy Costs: \t" + Math.Round(maintenanceCosts["annualMaintenanceCosts"], 2) + " zł\n"
            + "Monthly Costs: \t" + Math.Round(maintenanceCosts["monthlyMaintenanceCosts"], 2) + " zł\n"
            + "Daily Costs: \t" + Math.Round(maintenanceCosts["dailyMaintenanceCosts"], 2) + " zł\n"
            + "Costs per Kilometer: \t" + Math.Round(maintenanceCosts["maintenanceCostsByKilometers"], 2) + " zł\n";
        }
    }
}
