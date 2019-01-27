using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //收藏表
    public class CollectionModel
    {
        public int id { get; set; }//主键
        public int carid { get; set; }//汽车外键
        public int userid { get; set; }//用户外键
        public int number1 { get; set; }//数量
    }
}
