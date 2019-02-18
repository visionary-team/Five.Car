using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //收藏表
    public class Collection
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 汽车外键
        /// </summary>
        public int Carid { get; set; }

        /// <summary>
        /// 用户外键
        /// </summary>
        public int Userid { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Number1 { get; set; }


        /// <summary>
        /// 颜色
        /// </summary>
        public string  ColorName { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        public string DISPLACEMENT { get; set; }

        /// <summary>
        /// 车辆品牌或型号
        /// </summary>
        public string CARBRAND { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImgUrl { get; set; }

        public int Price { get; set; } //车辆价格
        public string Carbrand { get; set; }//车辆品牌或型号
        public int Brandid { get; set; }//车辆品牌外键
    }
}
