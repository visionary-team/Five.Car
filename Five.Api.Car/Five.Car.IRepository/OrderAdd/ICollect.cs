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
        /// <summary>
        /// 我的收藏
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        List<Collection> ShowCollection( string Usersid);


        int Add(CarDetails carDetails);
    }
}
