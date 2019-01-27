using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //用户地址表
    public class AddresModel
    {
        public int id { get; set; }//主键Id
        public string uname { get; set; }//用户名称        g n
        public string phone { get; set; }//用户手机        g n
        public string useraddress { get; set; }//详细地址
        public int userid { get; set; }//相关用户
        public int provinceid { get; set; } //省市县id         
    }
}
