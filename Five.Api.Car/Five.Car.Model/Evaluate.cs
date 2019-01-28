using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //评价表
    public class Evaluate
    {
        public int Id { get; set; }//主键

        public string Content { get; set; }//评论内容

        public int Userid { get; set; }//属于用户

        public int Isdelete { get; set; }//是否删除

        public string State { get; set; }//评论类型
    }
}
