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
        private delegate string ValidatePassword(string password);

        public int AuthenticateUser(string username, string password)
        {
            ValidatePassword validatePassword = new ValidatePassword(HashPassword);
            string _hashedPassword = validatePassword(password);

            return FindUserId(username, _hashedPassword);
        }

        public int AuthenticateUser(string username, int pin)
        {
            string _pin = ParsePinToString(pin);

            ValidatePassword validatePassword = new ValidatePassword(CheckPinLength);
            validatePassword += HashPassword;
            string _hashedPassword = validatePassword(_pin);

            return FindUserId(username, _hashedPassword);
        }

        // Method returns PIN as a string value
        private string ParsePinToString(int pin)
        {
            return pin.ToString();
        }

        // Method checks if provided PIN is 4-digit length
        private string CheckPinLength(string password)
        {
            if (password.Length == 4) return password;
            else return "";
        }

        // Method hashes password
        private string HashPassword(string password)
        {
            return password.GetHashCode().ToString();
        }

        // Method returns userId for the provided credentials or 0 if account does not exsist
        private int FindUserId(string username, string password)
        {
            // Find the requested account
            var _userTable = _context.User;
            var _queryResult = _userTable.Where(user => user.Username.Equals(username) && user.Password.Equals(password));

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
