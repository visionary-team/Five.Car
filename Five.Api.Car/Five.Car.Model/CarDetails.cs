using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆详情表
    public class CarDetails
    {
        /// <summary>
        /// //主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// //车辆品牌外键
        /// </summary>
        public int Brandid { get; set; }

        /// <summary>
        /// //车辆颜色外键
        /// </summary>
        public int Carcolorid { get; set; }

        /// <summary>
        /// //车辆排量
        /// </summary>
        public string Displacement { get; set; }

        /// <summary>
        /// //车辆座位
        /// </summary>
        public int Seat { get; set; }

        /// <summary>
        /// //车辆所在地
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// //车辆详细描述
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// //车辆库存
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// //车辆价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// //时间
        /// </summary>
        public string Times { get; set; }

        /// <summary>
        /// //车辆id
        /// </summary>
        public int Carid { get; set; }
        public object Imgurl { get; set; }
    }
}
