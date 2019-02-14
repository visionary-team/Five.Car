using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository.OrderDetails
{
    public interface IUserInfo
    {
        /// <summary>
        /// 汽车订单表
        /// </summary>
        /// <returns></returns>
        List<OrderCarDetails> CarOrdreTable(int id);

        /// <summary>
        /// 汽车订单表全部
        /// </summary>
        /// <returns></returns>
        List<OrderCarDetails> CarOrdreTableAll();
    }
}
