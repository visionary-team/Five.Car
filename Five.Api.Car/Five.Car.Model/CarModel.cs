using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆品牌表
    public class CarModel
    {
        public int id { get; set; }//主键
        public int carbrand { get; set; }//车辆品牌或型号
        public int Pid { get; set; }//父级id
    }
}
