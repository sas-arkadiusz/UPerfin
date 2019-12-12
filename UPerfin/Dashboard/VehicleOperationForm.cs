using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPerfin.Vehicle;

namespace UPerfin.Dashboard
{
    public partial class VehicleOperationForm : MainForm
    {
        public VehicleOperationForm()
        {
            InitializeComponent();
        }

        public VehicleOperationForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void TypeOfTheVehicle_Click(object sender, EventArgs e)
        {
            if(CarRadioButton.Checked)
            {
                CostOfTheEmployeeLabel.Visible = false;
                EmployeeSalaryTextBox.Visible = false;
                EmployeeSalaryLabel.Visible = false;
            }
            else if(TruckRadioButton.Checked)
            {
                CostOfTheEmployeeLabel.Visible = true;
                EmployeeSalaryTextBox.Visible = true;
                EmployeeSalaryLabel.Visible = true;
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            bool isCar = CarRadioButton.Checked;
            bool isTruck = TruckRadioButton.Checked;
            bool isCarOrTruck = isCar || isTruck;
            if (isCar)
            {
                CalculatiorResultLabel.Visible = true;
                ErrorLabel.Text = "";
                EmployeeSalaryTextBox.Text = "0";
            }
            else if (isTruck)
            {
                CalculatiorResultLabel.Visible = true;
                ErrorLabel.Text = "";
            }
            
            if(isCarOrTruck)
            {

                VehicleInformation vehicle = new VehicleInformation
                {
                    PurchaseCost = Decimal.Parse(PurchaseCostTextBox.Text),
                    PurchaseYear = int.Parse(PurchaseYearTextBox.Text),
                    MileageOnPurchase = int.Parse(MileagePurchaseTextBox.Text),
                    MileageCurrent = int.Parse(MileageCurrentTextBox.Text),
                    ValueCurrent = Decimal.Parse(CurrentValueTextBox.Text),
                    FuelCosts = Decimal.Parse(FuelCostTextBox.Text),
                    InsuranceCosts = Decimal.Parse(InsuranceTextBox.Text),
                    CarWashCosts = Decimal.Parse(CarWashTextBox.Text),
                    ServiceCosts = Decimal.Parse(ServiceCostTextBox.Text),
                    ParkingCosts = Decimal.Parse(ParkingCostTextBox.Text),
                    OtherCosts = Decimal.Parse(OthersTextBox.Text),
                    EmployeeSalary = Decimal.Parse(EmployeeSalaryTextBox.Text)
                };

                if(isCar)
                {
                    Car car = new Car();
                    Dictionary<string, decimal> carCosts = car.CalculateMaintenanceCosts(vehicle);
                    CalculatiorResultLabel.Text = car.GenerateFormattedReport(carCosts);
                }
                else if(isTruck)
                {
                    Truck truck = new Truck();
                    Dictionary<string, decimal> truckCosts = truck.CalculateMaintenanceCosts(vehicle);
                    CalculatiorResultLabel.Text = truck.GenerateFormattedReport(truckCosts);
                }
            }
            else 
            {
                ErrorLabel.Text = "Set the type of the Vehicle!";
            }
        }

        private void ClearInputs_Click(object sender, EventArgs e)
        {
            PurchaseCostTextBox.Text = "Purchase Cost...";
            PurchaseYearTextBox.Text = "Year of the Purchase...";
            MileagePurchaseTextBox.Text = "Mileage on the day of the Purchase...";
            MileageCurrentTextBox.Text = "Current Mileage...";
            CurrentValueTextBox.Text = "Current Value...";
            FuelCostTextBox.Text = "Fuel Costs... (monthly)";
            InsuranceTextBox.Text = "Insurance Costs... (annually)";
            CarWashTextBox.Text = "Car Wash Costs... (monthly)";
            ServiceCostTextBox.Text = "Service Costs... (annually)";
            ParkingCostTextBox.Text = "Parking Costs... (monthly)";
            OthersTextBox.Text = "Other Costs... (monthly)";
            EmployeeSalaryTextBox.Text = "Employee Salary... (monthly)";
        }
    }
}
