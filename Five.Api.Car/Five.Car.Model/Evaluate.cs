using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //评价表
    public class Evaluate
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 属于用户
        /// </summary>
        public string Userid { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public int Isdelete { get; set; }

        /// <summary>
        /// 评论类型
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 汽车详情外键
        /// </summary>
        public int CarDetailsId { get; set; }


        /// <summary>
        /// 图片路径
        /// </summary>
        public string Imgurl { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        public string Carbrand { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string Colorname { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        public string Displacement { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }



        public int num { get; set; }
    }
}
