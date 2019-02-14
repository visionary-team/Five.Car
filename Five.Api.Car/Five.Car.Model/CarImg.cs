using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆图片表
    public class CarImg
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string Imgurl { get; set; }

        /// <summary>
        /// 车辆id
        /// </summary>
        public int Carid { get; set; }
    }
}
