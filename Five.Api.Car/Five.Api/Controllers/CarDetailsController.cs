using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.Repository;
using Five.Car.Model;

namespace Five.Api.Controllers
{
    public class CarDetailsController : ApiController
    {
        public IRotationChartRepository Rotation { get; set; }
        public ICarBrand CarBrand { get; set; }
        public ICarDetailsRepository CarDetail { get; set; }

        [HttpGet]
        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Rotationchart> ShowRotation()
        {
            var RotationList = Rotation.ShowRotationchart();
            return RotationList;
        }

        [HttpGet]
        /// <summary>
        /// 汽车详情显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarDetails> CarDetailsShow(int id)
        {
            var CarDetailes = CarDetail.CarDetailShow(id);
            return CarDetailes;
        }

        [HttpGet]
        /// <summary>
        /// 关于汽车品牌的显示
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public List<Cars> CarBrandShow(int Pid)
        {
            var CarBrands = CarBrand.CarBrandShow(Pid);
            return CarBrands;
        }       
    }
}
