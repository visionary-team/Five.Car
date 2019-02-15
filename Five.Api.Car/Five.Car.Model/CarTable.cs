using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆品牌表
    public class CarTable
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车辆品牌或型号
        /// </summary>
        public string Carbrand { get; set; }

        /// <summary>
        /// 父级id
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        public string ImageUrl { get; set; }
    }
}
