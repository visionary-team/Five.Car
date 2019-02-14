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
        [HttpGet]
        public int AddCarDetails()
        {
            CarDetails addr = new CarDetails();
            addr.Brandid = Convert.ToInt32( HttpContext.Current.Request["Brandid"]);
            addr.Carcolorid = Convert.ToInt32(HttpContext.Current.Request["Carcolorid"]);
            addr.Displacement = HttpContext.Current.Request["Displacement"];
            addr.Address = HttpContext.Current.Request["Address"];
            addr.Price = Convert.ToInt32(HttpContext.Current.Request["Price"]);
            addr.Imgurl = HttpContext.Current.Request["Imgurl"];
            int addaddress = Collect.AddCarDetails(addr);
            return addaddress;
        }
    }
}
