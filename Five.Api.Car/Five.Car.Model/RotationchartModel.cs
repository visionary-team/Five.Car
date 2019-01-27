using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //轮播图表
    public class RotationchartModel
    {
        public int Id { get; set; }//主键
        public string Url { get; set; }//路径
        public int CarDetailsid { get; set; }//汽车详细ID
    }
}
