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
        public int Id { get; set; }//主键Id

        public int Brandid { get; set; }//车辆品牌外键

        public int Carcolorid { get; set; }//车辆颜色外键

        public string Displacement { get; set; }//车辆排量

        public int Seat { get; set; }//车辆座位

        public string Address { get; set; }//车辆所在地

        public string Details { get; set; }//车辆详细描述

        public int Stock { get; set; }//车辆库存

        public int Price { get; set; } //车辆价格
    }
}
