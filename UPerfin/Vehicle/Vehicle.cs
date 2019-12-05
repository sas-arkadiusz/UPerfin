using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Vehicle
{
    class VehicleInformation
    {
        public decimal PurchaseCost { get; set; }
        public int PurchaseYear { get; set; }
        public int MileageOnPurchase { get; set; }
        public int MileageCurrent { get; set; }
        public decimal ValueCurrent { get; set; }

        public decimal FuelCosts { get; set; }
        public decimal InsuranceCosts { get; set; }
        public decimal CarWashCosts { get; set; }
        public decimal ServiceCosts { get; set; }
        public decimal ParkingCosts { get; set; }
        public decimal OtherCosts { get; set; }

        public decimal EmployeeSalary { get; set; }
    }
}
