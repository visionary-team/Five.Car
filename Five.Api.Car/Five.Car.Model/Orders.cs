using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //订单表
    public class Orders
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Numbers { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 汽车id
        /// </summary>
        public int Carid { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public string Useid { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public int Paymentid { get; set; }
    }
}
