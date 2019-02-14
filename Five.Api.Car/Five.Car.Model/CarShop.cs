using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    public class CarShop
    {
        public int Id { get; set; }//主键Id

        /// <summary>
        /// 车辆品牌外键
        /// </summary>
        public int Brandid { get; set; }

        public int Carcolorid { get; set; }//车辆颜色外键

        public string Displacement { get; set; }//车辆排量

        public int Seat { get; set; }//车辆座位

        public string Address { get; set; }//车辆所在地

        public string Details { get; set; }//车辆详细描述

        public int Stock { get; set; }//车辆库存

        public int Price { get; set; } //车辆价格

        public string Times { get; set; }   //时间

        public string Imgurl { get; set; }//图片路径

        public int Carid { get; set; }//车辆id

        public string Colorname { get; set; }//车辆颜色

        public string Carbrand { get; set; }//车辆品牌或型号

        public int Pid { get; set; }//父级id

        public string ImageUrl { get; set; }//品牌logo

        public string Series { get; set; }  //汽车的系列

        public int IsCollection { get; set; }//是否收藏
    }
}
