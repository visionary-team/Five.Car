using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository
{
   public interface IAddressDetailsRepository
    {
        int IAdd(Address addr);
        List<Address> GetAddress();
        int Delete(int id);


    }
}
