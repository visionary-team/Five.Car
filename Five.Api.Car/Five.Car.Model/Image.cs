using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //车辆图片表
    public class Image
    {
        public int Id { get; set; }//主键

        public string Imgurl { get; set; }//图片路径

        public int Carid { get; set; }//车辆id
    }
}
