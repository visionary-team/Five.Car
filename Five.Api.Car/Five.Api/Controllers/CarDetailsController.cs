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
    }
}
