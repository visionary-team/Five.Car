using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.Repository;
using Five.Car.Model;
using Newtonsoft.Json;
using Five.Car.Command;
using CommonCache;

namespace Five.Api.Controllers
{
    public class CarDetailsController : ApiController
    {
        public IRotationChartRepository Rotation { get; set; }

        public ICarBrandRepository CarBrand { get; set; }

        public ICarDetailsRepository CarDetail { get; set; }

        public ICollectionRepository collectionRepository { get; set; }

        [HttpGet]
        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Rotationchart> GetRotationcharts()
        {
            var RotationList = Rotation.GetRotationcharts();
            return RotationList;
        }

        [HttpGet]
        /// <summary>
        /// 根据Id显示单个的汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> GetCarShopsById(int id)
        {
            var CarDetailes = CarDetail.GetCarShopsById(id);
            return CarDetailes;
        }

        [HttpGet]
        /// <summary>
        /// 显示所有的汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> GetCarShops()
        {
            var CarAllDetailes = CarDetail.GetCarShops();
            return CarAllDetailes;
        }

        [HttpGet]
        /// <summary>
        /// 关于汽车品牌的显示
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        [ActionName("CarBrandShow")]
        public List<CarTable> GetCarTables(int Pid, string Brand)
        {
            var CarBrands = CarBrand.GetCarTables(Pid, Brand);
            return CarBrands;
        }

        /// <summary>
        /// 修改商品是否收藏
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isCollection"></param>
        /// <returns></returns>
        [HttpGet]
        public int UpdateCarCollection(int id, int isCollection)
        {
            var i = collectionRepository.UpdateCarCollection(id,isCollection);
            return i;
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
                string appid = "wx9cfd1269436269a8";//开发者ID
                string secret = "4b62a45558a4aa06e717c73a2b3229ef";//开发者秘钥
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
