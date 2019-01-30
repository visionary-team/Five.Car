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
        public int Id { get; set; }//主键
        public int Carid { get; set; }//汽车外键
        public int Userid { get; set; }//用户外键
        public int Number1 { get; set; }//数量



        public string  ColorName { get; set; }
        public string DISPLACEMENT { get; set; }
        public string CARBRAND { get; set; }
        public string ImgUrl { get; set; }
    }
}
