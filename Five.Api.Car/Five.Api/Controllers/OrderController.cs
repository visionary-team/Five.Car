using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.Repository;
using Five.Car.Model;
using Five.Car.IRepository.OrderDetails;

namespace Five.Api.Controllers
{
    public class OrderController : ApiController
    {
        public IUserInfo Iuser { get; set; }
        /// <summary>
        /// 汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<OrderCarDetails> CarOrdreTable()
        {
            var OrderCar = Iuser.CarOrdreTable();
            return OrderCar;
        }
    }
    
}
