using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //用户地址表
    public class Address
    {
        public int Id { get; set; }//主键Id

        public string UName { get; set; }//用户名称 

        public string Phone { get; set; }//用户手机  

        public string Province { get; set; } //省市县   

        public string Useraddress { get; set; }//详细地址

        public int Userid { get; set; }//相关用户

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }  


    }
}
