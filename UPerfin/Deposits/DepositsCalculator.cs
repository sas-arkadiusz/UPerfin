using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Deposits
{
    class DepositsCalculator
    {
        private static readonly decimal TAX_VALUE = 0.19m;

        public static decimal CalculateDepositGain(decimal DepositAmount, decimal DepositInterest, int DepositTimeInMonth)
        {
            return DepositAmount * (DepositInterest / 100) * DepositTimeInMonth / 12;
        }

        public static decimal CalculateDepositGainWithTax(decimal DepositAmount, decimal DepositInterest, int DepositTimeInMonth)
        {
            return (DepositAmount * (DepositInterest / 100) * DepositTimeInMonth / 12) * (1 - TAX_VALUE);

        }
    }
}
