using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    public class OrderCarDetails
    {
        public int Id { get; set; }//Id

        public int Price { get; set; } //车辆价格

        public int State { get; set; }//状态

        public string Times { get; set; }   //时间

        public string Imgurl { get; set; }//图片路径

        public string Address { get; set; }//车辆所在地
    }
}
