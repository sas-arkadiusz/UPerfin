using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Constants
{
    class RegistrationAnnotation
    {
        public const string UsernameFormat = @"^[a-zA-Z0-9]{1,20}$";
        public const string EmailFormat = @"[^@]+@[^\.]+\..+";
        public const string PasswordFormat = @"^.{1,20}$";
        public const string PinFormat = @"^\d{4}$";
    }
}
