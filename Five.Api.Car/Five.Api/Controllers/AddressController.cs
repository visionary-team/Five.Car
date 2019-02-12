using Five.Car.IRepository;
using Five.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public int AddressDetails(Address addr)
        {
            int addaddress = Iaddress.IAdd(addr);
            return addaddress;
        }

        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Address> Show()
        {
            var addresslist = Iaddress.Show();
            return addresslist;
        }
    }
}
