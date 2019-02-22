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
        /// 地址
        /// </summary>
        /// <returns></returns>
        List<Address> Address(string userId);

        /// <summary>
        /// 订单
        /// </summary>
        /// <returns></returns>
        List<Orders> ShowOrders();

        /// <summary>
        /// 车辆详情下拉
        /// </summary>
        /// <returns></returns>
        List<CarTable> Details();

        /// <summary>
        /// 车辆颜色下拉
        /// </summary>
        /// <returns></returns>
        List<CarColor> Color();
    }
}
