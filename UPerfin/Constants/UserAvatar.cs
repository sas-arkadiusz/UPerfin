using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Constants
{
    class UserAvatar
    {
        private static Image _defaultAvatar = Properties.Resources.UserPicture_32x32;
        private static Image _avocadoAvatar = Properties.Resources.Avocado_64x64;
        private static Image _batmanAvatar = Properties.Resources.Batman_64x64;
        private static Image _santaAvatar = Properties.Resources.Santa_64x64;
        private static Image _ninjaAvatar = Properties.Resources.Ninja_64x64;

        public static Image GetAvatar(string avatarName)
        {
            switch (avatarName)
            {
                case "avocado":
                    return _avocadoAvatar;
                case "batman":
                    return _batmanAvatar;
                case "santa":
                    return _santaAvatar;
                case "ninja":
                    return _ninjaAvatar;
            }
            return null;
        }
    }
}
