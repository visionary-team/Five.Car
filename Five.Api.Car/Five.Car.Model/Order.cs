using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //订单表
    public class Order
    {
        public int Id { get; set; }//主键

        public int Numbers { get; set; }//数量

        public int Price { get; set; }//总价

        public int Carid { get; set; }//汽车id

        public int State { get; set; }//状态

        public int Useid { get; set; }//用户id

        public int Paymentid { get; set; }//支付方式
    }
}
