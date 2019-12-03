using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.Models;

namespace UPerfin.DAOs
{
    class TransactionDAO : IDataDAO<Transaction>
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();

        public Transaction GetElementById(int id)
        {
            var _transactionTable = _context.Transaction;
            var _queryResult = _transactionTable.Where(transaction => transaction.Id == id);

            try
            {
                return _queryResult.First();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Transaction not found!");
                Console.WriteLine(exception.StackTrace);
                return null;
            }
        }

        public List<Transaction> GetTransactions(int userId)
        {
            var _transactionTable = _context.Transaction;
            var _queryResult = _transactionTable.Where(transaction => transaction.UserId == userId);

            try
            {
                return _queryResult.ToList();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Transactions not found!");
                Console.WriteLine(exception.StackTrace);
                return null;
            }
        }
    }
}
