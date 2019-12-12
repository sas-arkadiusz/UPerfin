using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.Models;

namespace UPerfin.DAOs
{
    class IncomeDAO : IDataDAO<Income>
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();

        public Income GetElementById(int id)
        {
            var _incomeTable = _context.Income;
            var _queryResult = _incomeTable.Where(income => income.Id == id);

            try
            {
                return _queryResult.First();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Income not found!");
                Console.WriteLine(exception.StackTrace);
                return null;
            }
        }

        public List<Income> GetIncomes(int userId)
        {
            var _incomeTable = _context.Income;
            var _queryResult = _incomeTable.Where(income => income.UserId == userId);

            try
            {
                return _queryResult.ToList();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Incomes not found!");
                Console.WriteLine(exception.StackTrace);
                return null;
            }
        }
    }
}
