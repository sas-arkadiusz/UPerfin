using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.Models;

namespace UPerfin.AuthenticationProcess
{
    class UserAuthenticator
    {
        private readonly UperfindbContext _context = new UperfindbContext();

        public int AuthenticateUser(string username, string password)
        {
            // Hash the password
            string _hashedPassword = password.GetHashCode().ToString();

            // Find the requested account
            var _userTable = _context.User;
            var _queryResult = _userTable.Where(user => user.Username.Equals(username) && user.Password.Equals(_hashedPassword));
            
            // Return authenticated userId
            try
            {
                return _queryResult.First().Id;
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("User not found!");
                Console.WriteLine(exception.StackTrace);
                return 0;
            }
        }
    }
}
