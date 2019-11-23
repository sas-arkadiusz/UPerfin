using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.Models;

namespace UPerfin.DAOs
{
    class UserDAO : IDataDAO<User>
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();

        public User GetElementById(int id)
        {
            var _userTable = _context.User;
            var _queryResult = _userTable.Where(user => user.Id == id);
            var _tranTable = _context.Transaction;
            var _tranResult = _tranTable.Where(tran => tran.Id == 1);
            Transaction t = _tranResult.First();
            Console.WriteLine(t.TransactionAmount);

            try
            {
                return _queryResult.First();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("User not found!");
                Console.WriteLine(exception.StackTrace);
                return null;
            }
        }
    }
}
