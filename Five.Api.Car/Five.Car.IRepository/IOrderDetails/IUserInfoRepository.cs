using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository.IOrderDetails
{
    public interface IUserInfoRepository
    {
        /// <summary>
        /// 汽车订单表
        /// </summary>
        /// <returns></returns>
        List<OrderCarDetails> GetCarOrdreById(int id);

        /// <summary>
        /// 汽车订单表全部
        /// </summary>
        /// <returns></returns>
        List<OrderCarDetails> GetCarOrdreAll();

        /// <summary>
        /// 根据ID显示车辆详情
        /// </summary>
        /// <returns></returns>
        List<CarShop> GetCarDetailById(int id);

        /// <summary>
        /// 付款修改车辆订单状态
        /// </summary>
        int UpdateCarOrderState(int id);

        /// <summary>
        /// 根据Order ID 显示付款页面信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<CarShop> GetOrdersById(int id);
    }
}
