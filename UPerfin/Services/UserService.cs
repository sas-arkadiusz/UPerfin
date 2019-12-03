using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPerfin.DAOs;
using UPerfin.Models;

namespace UPerfin.Services
{
    class UserService : IDataService<User>
    {
        private readonly UserDAO _userDAO = new UserDAO();

        public User GetElementById(int id)
        {
            return _userDAO.GetElementById(id);
        }
    }
}
