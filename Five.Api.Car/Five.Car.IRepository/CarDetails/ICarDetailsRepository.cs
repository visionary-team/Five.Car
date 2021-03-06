﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository
{
    public interface ICarDetailsRepository
    {
        /// <summary>
        /// 关于根据Id显示汽车详情
        /// </summary>
        /// <returns></returns>
        List<CarShop> GetCarShopsById(int pid);

        /// <summary>
        /// 显示全部的汽车详情
        /// </summary>
        /// <returns></returns>
        List<CarShop> GetCarShops();

        /// <summary>
        /// 根据汽车品牌获取内容
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        List<CarShop> GetCarShopsByCid(int cid);
    }
}
