using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UPerfin.Constants;
using UPerfin.Models;

namespace UPerfin.AuthenticationProcess
{
    class UserRegistration
    {
        private readonly uperfindbEntities _context = new uperfindbEntities();
        private delegate bool ValidateCredentials(string username, string email, string password, string pin);

        public bool RegisterUser(string username, string email, string password, string pin)
        {
            ValidateCredentials validateCredentials = new ValidateCredentials(ValidateLength);
            validateCredentials += ValidateAllCredentials;

            if(validateCredentials(username, email, password, pin))
            {
                User user = CreateUser(username, email, password, pin);
                SaveUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method valdiates credentials' length.
        private bool ValidateLength(string username, string email, string password, string pin)
        {
            if (username.Length == 0) return false;
            if (email.Length == 0) return false;
            if (password.Length == 0) return false;
            if (pin.Length == 0) return false;
            return true; 
        }

        // Method validates credentials.
        private bool ValidateAllCredentials(string username, string email, string password, string pin)
        {
            if (!ValidateUsername(username)) return false;
            if (!ValidateEmail(email)) return false;
            if (!ValidatePassword(password)) return false;
            if (!ValidatePin(pin)) return false;
            return true;
        }

        // Method validates username.
        // Username has to contain only letters or digits.
        private bool ValidateUsername(string username)
        {
            if(Regex.IsMatch(username, RegistrationAnnotation.UsernameFormat)) return true;
            return false;
        }

        // Method validates email address.
        private bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, RegistrationAnnotation.EmailFormat)) return true;
            return false;
        }

        // Method validates password.
        private bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, RegistrationAnnotation.PasswordFormat)) return true;
            return false;
        }

        // Method validates PIN.
        // PIN has to be numeric and has to have exactly 4 digitis.
        private bool ValidatePin(string pin)
        {
            if (Regex.IsMatch(pin, RegistrationAnnotation.PinFormat)) return true;
            return false;
        }

        // Method hashes password
        private string HashPassword(string password)
        {
            return password.GetHashCode().ToString();
        }

        // Method creats new User object.
        private User CreateUser(string username, string email, string password, string pin)
        {
            return new User{ Username = username, Email = email, Password = HashPassword(password), PIN = HashPassword(pin) };
        }

        // Method saves new User record to the database.
        private void SaveUser(User user)
        {
            var users = _context.Set<User>();
            users.Add(user);
            _context.SaveChanges();
        }
    }
}
