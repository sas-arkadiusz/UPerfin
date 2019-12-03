using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.DAOs;
using UPerfin.Models;

namespace UPerfin.Services
{
    class TransactionService : IDataService<Transaction>
    {
        private readonly TransactionDAO _transactionDAO = new TransactionDAO();

        public Transaction GetElementById(int id)
        {
            return _transactionDAO.GetElementById(id);
        }

        public List<Transaction> GetTransactions(int userId)
        {
            return _transactionDAO.GetTransactions(userId);
        }

        public decimal GetSumOfAllTransactions(int userId)
        {
            return GetTransactions(userId)
                .Where(transaction => transaction.UserId == userId)
                .Sum(transaction => transaction.TransactionAmount);
        }

        public decimal GetSumOfSpecificCategory(int userId, Category category)
        {
            return GetTransactions(userId)
                .Where(transaction => transaction.TransactionCategory.Equals(category.ToString()))
                .Sum(transaction => transaction.TransactionAmount);
        }

        public decimal GetSumByMonth(int userId, int month)
        {
            return GetTransactions(userId)
                .Where(transaction => (transaction.TransactionDate.Month == month))
                .Sum(transaction => transaction.TransactionAmount);
        }

        public Dictionary<string, decimal> GetOutcomesByMonth(int userId)
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

        public Dictionary<string, decimal> GetOutcomesByCategory(int userId)
        {
            return new Dictionary<string, decimal>
            {
                { "Sum", GetSumOfAllTransactions(userId) },
                { "Food", GetSumOfSpecificCategory(userId, Category.Food) },
                { "Health", GetSumOfSpecificCategory(userId, Category.Health) },
                { "Shopping", GetSumOfSpecificCategory(userId, Category.Shopping) },
                { "Transport", GetSumOfSpecificCategory(userId, Category.Transport) },
                { "Bills", GetSumOfSpecificCategory(userId, Category.Bills) },
                { "Home", GetSumOfSpecificCategory(userId, Category.Home) },
                { "Entertainment", GetSumOfSpecificCategory(userId, Category.Entertainment) },
                { "Holidays", GetSumOfSpecificCategory(userId, Category.Holidays) },
                { "Education", GetSumOfSpecificCategory(userId, Category.Education) },
                { "Other", GetSumOfSpecificCategory(userId, Category.Other) }
            };
        }
    }
}
