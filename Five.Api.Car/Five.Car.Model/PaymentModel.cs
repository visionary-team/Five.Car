using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Model
{
    //支付方式
    public class PaymentModel
    {
        public int Id { get; set; }//主键
        public string Method { get; set; }//支付方式
    }
}
