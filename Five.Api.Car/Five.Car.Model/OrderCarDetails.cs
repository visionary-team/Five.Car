using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    public class OrderCarDetails
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车辆价格
        /// </summary>
        public int Price { get; set; } 

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public string Times { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string Imgurl { get; set; }

        /// <summary>
        /// 车辆所在地
        /// </summary>
        public string Address { get; set; }
    }
}
