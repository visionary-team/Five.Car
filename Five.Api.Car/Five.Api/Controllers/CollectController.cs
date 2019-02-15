﻿using Five.Car.IRepository;
using Five.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Five.Api.Controllers
{
    public class CollectController : ApiController
    {
        public ICollect Collect { get; set; }
        /// <summary>
        /// 我的收藏
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Collection> ShowCollection(string Usersid)
        {
            var collects = Collect.ShowCollection(Usersid);
            return collects;
        }
        /// <summary>
        /// 发布车辆
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int AddCarDetails()
        {
            CarDetails details = new CarDetails();
            details.Brandid = Convert.ToInt32( HttpContext.Current.Request["Brandid"]);
            details.Carcolorid = Convert.ToInt32(HttpContext.Current.Request["Carcolorid"]);
            details.Displacement = HttpContext.Current.Request["Displacement"];
            details.Address = HttpContext.Current.Request["Address"];
            details.Price = Convert.ToInt32(HttpContext.Current.Request["Price"]);
            details.Imgurl = HttpContext.Current.Request["Imgurl"];
            int issue = Collect.AddCarDetails(details);
            return issue;
        }
        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        [ActionName("ShowAddress")]
        [HttpGet]
        public List<Address> ShowAddress()
        {
            var address = Collect.Address();
            return address;
        }

        /// <summary>
        /// 订单
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Collection> ShowOrders(string Usersid)
        {
            var orders = Collect.ShowCollection(Usersid);
            return orders;
        }
    }
}
