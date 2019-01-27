using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆详情表
    public class CarDetailsModel
    {
        public int id { get; set; }//主键Id
        public int brandid { get; set; }//车辆品牌外键
        public int carcolorid { get; set; }//车辆颜色外键
        public string displacement { get; set; }//车辆排量
        public int seat { get; set; }//车辆座位
        public string address { get; set; }//车辆所在地
        public string details { get; set; }//车辆详细描述
        public int stock { get; set; }//车辆库存
        public int price { get; set; } //车辆价格
    }
}
