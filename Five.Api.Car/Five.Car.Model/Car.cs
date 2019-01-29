using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆品牌表
    public class Car
    {
        public int Id { get; set; }//主键

        public int Carbrand { get; set; }//车辆品牌或型号

        public int Pid { get; set; }//父级id

        public string ImageUrl { get; set; }//品牌logo
    }
}
