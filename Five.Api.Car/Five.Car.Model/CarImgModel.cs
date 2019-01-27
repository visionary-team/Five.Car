using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆图片表
    public class CarImgModel
    {
        public int id { get; set; }//主键
        public string imgurl { get; set; }//图片路径
        public int carid { get; set; }//车辆id
    }
}
