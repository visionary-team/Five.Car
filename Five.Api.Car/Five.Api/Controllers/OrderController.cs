using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.Repository;
using Five.Car.Model;
using Five.Car.IRepository.IOrderDetails;
using Newtonsoft.Json;
using Five.Car.Cache;
using System.Web;

namespace Five.Api.Controllers
{
    public class OrderController : ApiController
    {
        public IUserInfoRepository Iuser { get; set; }

        /// <summary>
        /// 根据ID显示汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetCarDetailById")]
        public List<CarShop> GetCarDetailById(int id)
        {
            var carDetail = Iuser.GetCarDetailById(id);
            return carDetail;
        }

        /// <summary>
        /// 单个汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetCarOrdreById")]
        public List<OrderCarDetails> GetCarOrdreById(int id,string userId)
        {
            var orderCar = Iuser.GetCarOrdreById(id, userId);
            return orderCar;
        }

        /// <summary>
        /// 所有汽车订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetCarOrdreAll")]
        public List<OrderCarDetails> GetCarOrdreAll(string userId)
        {
            var orderCar = Iuser.GetCarOrdreAll(userId);
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

        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        [HttpGet]
        public int Add()
        {
            Orders orders = new Orders();
            orders.Price =Convert.ToInt32(HttpContext.Current.Request["Price"]);
            orders.Carid = Convert.ToInt32(HttpContext.Current.Request["Carid"]);
            orders.Useid = HttpContext.Current.Request["Useid"];
            var add = Iuser.Add(orders);
            return add;
        }

        /// <summary>
        /// 手机端登录
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet]
        public ClientInfo Login(string code)
        {
            var client = Logins(code);
            return client;
        }

        /// <summary>
        /// 获取微信会话密钥
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ClientInfo Logins(string code)
        {
            ClientInfo clientinfo = new ClientInfo();
            HttpClient httpclient = new HttpClient();

            //登陆公众平台 开发->基本配置中的开发者ID(AppID)和 开发者密码(AppSecret)
            string appid = "wx82db98b607d9f205";//开发者ID
            string secret = "f7a4a232423b21653374a4b43ba36bc5";//开发者秘钥
            httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = httpclient.PostAsync("https://api.weixin.qq.com/sns/jscode2session?appid=" + appid + "&secret=" + secret + "&js_code=" + code.ToString() + "&grant_type=authorization_code", null).Result;
            var result = "";
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
            httpclient.Dispose();
            var results = JsonConvert.DeserializeObject<ClientInfo>(result);
            clientinfo.OpenId = results.OpenId;//用户唯一标识
            clientinfo.session_key = results.session_key;//密钥
            RedisHelper.Set<ClientInfo>(clientinfo.session_key, clientinfo, DateTime.Now.AddHours(10));
            return clientinfo;
        }
    }
    
}
