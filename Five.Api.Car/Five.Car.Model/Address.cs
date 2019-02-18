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
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名称 
        /// </summary>
        public string UName { get; set; }

        /// <summary>
        /// 用户手机
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 省市县
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string Useraddress { get; set; }

        /// <summary>
        /// 相关用户
        /// </summary>
        public int Userid { get; set; }

        /// <summary>
        /// 地址状态
        /// </summary>
        public int State { get; set; }

       
       
    }
}
