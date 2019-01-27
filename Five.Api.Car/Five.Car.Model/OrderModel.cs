using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //订单表
    public class OrderModel
    {
        public int id { get; set; }//主键
        public int numbers { get; set; }//数量
        public int price { get; set; }//总价
        public int carid { get; set; }//汽车id
        public int state { get; set; }//状态
        public int useid { get; set; }//用户id
        public int paymentid { get; set; }//支付方式
    }
}
