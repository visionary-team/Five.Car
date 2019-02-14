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
        /// 根据Id显示单个的汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> CarDetailsShow(int id)
        {
            var CarDetailes = CarDetail.CarDetailShow(id);
            return CarDetailes;
        }

        [HttpGet]
        /// <summary>
        /// 显示所有的汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> CarDetailAllShow()
        {
            var CarAllDetailes = CarDetail.CarDetailAllShow();
            return CarAllDetailes;
        }

        [HttpGet]
        /// <summary>
        /// 关于汽车品牌的显示
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        [ActionName("CarBrandShow")]
        public List<Cars> CarBrandShow(int Pid, string Brand)
        {
            var CarBrands = CarBrand.CarBrandShow(Pid, Brand);
            return CarBrands;
        }       
    }
}
