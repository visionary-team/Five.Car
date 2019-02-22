using Five.Car.IRepository;
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

        public ICarDetailsRepository carDetailsRepository { get; set; }

        /// <summary>
        /// 我的收藏
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Collection> ShowCollection(string Usersid)
        {
            var Collects = Collect.ShowCollection(Usersid);
            return Collects;
        }
        /// <summary>
        /// 发布车辆
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int AddCarDetails()
        {
            CarDetails details = new CarDetails();
            Image image = new Image();
            details.Brandid =Convert.ToInt32(HttpContext.Current.Request["Brandid"]);
            details.Carcolorid =Convert.ToInt32(HttpContext.Current.Request["Carcolorid"]);
            details.Displacement = HttpContext.Current.Request["Displacement"];
            details.Address = HttpContext.Current.Request["Address"];
            details.Price = Convert.ToInt32(HttpContext.Current.Request["Price"]);
            details.Stock = Convert.ToInt32(HttpContext.Current.Request["Stock"]);
            details.Times = HttpContext.Current.Request["Times"];
            details.Details = HttpContext.Current.Request["Details"];
            details.Seat = Convert.ToInt32(HttpContext.Current.Request["Seat"]);
            image.Imgurl = HttpContext.Current.Request["Imgurl"];
            int Issue = Collect.AddCarDetails(details);
            return Issue;
        }
        /// <summary>
        /// 地址
        /// </summary>
        /// <returns></returns>
        [ActionName("ShowAddress")]
        [HttpGet]
        public List<Address> ShowAddress(string userId)
        {
            var Address = Collect.Address(userId);
            return Address;
        }

        /// <summary>
        /// 订单
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<CarShop> ShowOrders(int id)
        {
            var Orders = carDetailsRepository.GetCarShopsById(id);
            return Orders;
        }

        /// <summary>
        /// 车辆详情下拉
        /// </summary>
        /// <returns></returns>
        /// 
        [ActionName("ShowCarDetails")]
        [HttpGet]
        public List<CarTable> ShowCarDetails()
        {
            var Details =Collect.Details();
            return Details;
        }

        /// <summary>
        /// 车辆颜色下拉
        /// </summary>
        /// <returns></returns>
        [ActionName("ShowCarColor")]
        [HttpGet]
        public List<CarColor> ShowCarColor()
        {
            var Color = Collect.Color();
            return Color;
        }
    }
}
