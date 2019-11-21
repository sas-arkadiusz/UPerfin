using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPerfin.Services
{
    interface IDataService<T>
    {
        T GetElementById(int id);
    }
}