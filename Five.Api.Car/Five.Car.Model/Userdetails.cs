using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //用户详情表
    public class Userdetails
    {
        public int Id { get; set; }//主键id

        public string Uname { get; set; }//用户名称

        public string Usex { get; set; }//用户性别

        public string Uemail { get; set; }//邮箱

        public string Uimg { get; set; }//路径

        public string Phone { get; set; }//电话

        public int State { get; set; }//是否默认
    }
}
