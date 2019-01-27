using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //评价表
    public class EvaluateModel
    {
        public int id { get; set; }//主键
        public string content { get; set; }//评论内容
        public int userid { get; set; }//属于用户
        public int isdelete { get; set; }//是否删除
        public string state { get; set; }//评论类型
    }
}
