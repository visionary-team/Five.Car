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
    public class AddressController : ApiController
    {

        public IAddressDetailsRepository addressDetails { get; set; }


        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        [HttpGet]
        public int AddressDetails()
        {
            Address addr = new Address();//实例化实体类
            //接收前台数据
            addr.UName = HttpContext.Current.Request["UName"];
            addr.Phone = HttpContext.Current.Request["Phone"];
            addr.Province = HttpContext.Current.Request["Province"];
            addr.Useraddress = HttpContext.Current.Request["UserAddress"];
            addr.Userid = HttpContext.Current.Request["Userid"];

            int i = addressDetails.IAdd(addr);
            return i;
        }

        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAddress")]
        public List<Address> GetAddress(string userId)
        {
            var addresslist = addressDetails.GetAddress(userId);
            return addresslist;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int Del(int id)
        {
            int i = addressDetails.Delete(id);
            return i;
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Address> GetAddressById(int id)
        {
            var addresslist = addressDetails.GetAddressById(id);
            return addresslist;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int UptAddress()
        {
            Address addr = new Address();
            addr.Id = Convert.ToInt32(HttpContext.Current.Request["Id"]);
            addr.UName = HttpContext.Current.Request["UName"];
            addr.Phone = HttpContext.Current.Request["Phone"];
            addr.Province = HttpContext.Current.Request["Province"];
            addr.Useraddress = HttpContext.Current.Request["UserAddress"];
            int i = addressDetails.UptAddress(addr);
            return i;
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Uptstate()
        {
            Address addr = new Address();
            addr.Id = Convert.ToInt32(HttpContext.Current.Request["Id"]);
            addr.State = Convert.ToInt32(HttpContext.Current.Request["State"]);
            int i = addressDetails.UptState(addr);
            return i;
        }
    }
}
