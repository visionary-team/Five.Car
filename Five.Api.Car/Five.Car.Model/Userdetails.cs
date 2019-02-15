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
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string Uname { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        public string Usex { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Uemail { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public string Uimg { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 是否默认
        /// </summary>
        public int State { get; set; }
    }
}
