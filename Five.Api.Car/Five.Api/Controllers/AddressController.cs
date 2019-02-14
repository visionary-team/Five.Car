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

        public IAddressDetails Iaddress { get; set; }

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
            int addaddress = Iaddress.IAdd(addr);
            return addaddress;
        }

        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("Show")]
        public List<Address> Show()
        {
            var addresslist = Iaddress.Show();
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
            int i = Iaddress.Delete(id);
            return i;

        }
    }
}
