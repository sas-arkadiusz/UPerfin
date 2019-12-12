using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.DAOs;
using UPerfin.Models;

namespace UPerfin.Services
{
    class IncomeService : IDataService<Income>
    {
        private readonly IncomeDAO _incomeDAO = new IncomeDAO();

        public Income GetElementById(int id)
        {
            return _incomeDAO.GetElementById(id);
        }

        public List<Income> GetIncomes(int userId)
        {
            return _incomeDAO.GetIncomes(userId);
        }

        public decimal GetSumOfAllIncomes(int userId)
        {
            return GetIncomes(userId)
                .Where(income => income.UserId == userId)
                .Sum(income => income.IncomeAmount);
        }

        public decimal GetSumByMonth(int userId, int month)
        {
            return GetIncomes(userId)
                .Where(income => (income.IncomeDate.Month == month))
                .Sum(income => income.IncomeAmount);
        }

        public Dictionary<string, decimal> GetIncomesByMonth(int userId)
        {
            return new Dictionary<string, decimal>
            {
                { "January", GetSumByMonth(userId, 1) },
                { "February", GetSumByMonth(userId, 2) },
                { "March", GetSumByMonth(userId, 3) },
                { "April", GetSumByMonth(userId, 4) },
                { "May", GetSumByMonth(userId, 5) },
                { "June", GetSumByMonth(userId, 6) },
                { "July", GetSumByMonth(userId, 7) },
                { "August", GetSumByMonth(userId, 8) },
                { "September", GetSumByMonth(userId, 9) },
                { "October", GetSumByMonth(userId, 10) },
                { "November", GetSumByMonth(userId, 11) },
                { "December", GetSumByMonth(userId, 12) }
            };
        }
    }
}
