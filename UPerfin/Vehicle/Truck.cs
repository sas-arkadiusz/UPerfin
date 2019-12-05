using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Vehicle
{
    class Truck : Car
    {
        /*
         * Possible keys: annualMaintenanceCosts, monthlyMaintenanceCosts, dailyMaintenanceCosts, maintenanceCostsByKilometers
         */
        public override Dictionary<string, decimal> CalculateMaintenanceCosts(VehicleInformation vehicle)
        {
            Dictionary<string, decimal> truckMaintenance = new Dictionary<string, decimal>();

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
                (vehicle.OtherCosts * 12) +
                (vehicle.EmployeeSalary * 12);

            truckMaintenance.Add("annualMaintenanceCosts", annualMaintenanceCosts);
            truckMaintenance.Add("monthlyMaintenanceCosts", annualMaintenanceCosts / 12);
            truckMaintenance.Add("dailyMaintenanceCosts", annualMaintenanceCosts / 365);
            truckMaintenance.Add("maintenanceCostsByKilometers", (annualMaintenanceCosts * numberOfYears) / numberOfKilometers);
            return truckMaintenance;
        }
    }
}
