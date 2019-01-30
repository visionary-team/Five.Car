using Five.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.IRepository
{
   public interface ICollect
    {
        List<Collection> ShowCollection( string Usersid);
        
    }
}
