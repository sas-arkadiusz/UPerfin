using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.Models;

namespace UPerfin.Services
{
    class UserService : IDataService<User>
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();

        public User GetElementById(int id)
        {
            var _userTable = _context.User;
            var _queryResult = _userTable.Where(user => user.Id == id);

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
