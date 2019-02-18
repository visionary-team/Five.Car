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
        /// 根据ID显示汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("CarDetail")]
        public List<CarShop> CarDetail(int id)
        {
            var carDetail = Iuser.CarDetail(id);
            return carDetail;
        }

        /// <summary>
        /// 单个汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("CarOrdreTable")]
        public List<OrderCarDetails> CarOrdreTable(int id)
        {
            var orderCar = Iuser.CarOrdreTable(id);
            return orderCar;
        }

        /// <summary>
        /// 所有汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("CarOrdreTableAll")]
        public List<OrderCarDetails> CarOrdreTableAll()
        {
            var orderCar = Iuser.CarOrdreTableAll();
            return orderCar;
        }

        /// <summary>
        /// 付款修改车辆订单状态
        /// </summary>
        [HttpGet]
        public int UpdateCarOrderState(int  id)
        {
            var updateState = Iuser.UpdateCarOrderState(id);
            return updateState;
        }

        /// <summary>
        /// 根据Order ID 显示付款页面信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<CarShop> GetOrdersById(int id)
        {
            var getOrderById = Iuser.GetOrdersById(id);
            return getOrderById;
        }
    }
    
}
