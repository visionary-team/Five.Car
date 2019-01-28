using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //省事县表
    public class Provinces
    {
        public int Id { get; set; }//主键

        public string Provinname { get; set; }//省市县

        public int Pid { get; set; }//父级id
    }
}
