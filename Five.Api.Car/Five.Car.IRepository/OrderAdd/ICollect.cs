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

        /// <summary>
        /// 发布车辆
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        int AddCarDetails(CarDetails details);

        /// <summary>
        /// 车辆订单
        /// </summary>
        /// <returns></returns>
        List<Address> Address();

        /// <summary>
        /// 订单
        /// </summary>
        /// <returns></returns>
        List<Orders> ShowOrders();
    }
}
