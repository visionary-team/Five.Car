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
        /// 单个汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("CarOrdreTable")]
        public List<OrderCarDetails> CarOrdreTable(int id)
        {
            var OrderCar = Iuser.CarOrdreTable(id);
            return OrderCar;
        }

        /// <summary>
        /// 所有汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("CarOrdreTableAll")]
        public List<OrderCarDetails> CarOrdreTableAll()
        {
            var OrderCar = Iuser.CarOrdreTableAll();
            return OrderCar;
        }
    }
    
}
