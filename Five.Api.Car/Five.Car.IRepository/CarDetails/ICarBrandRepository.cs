using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository
{
    public interface ICarBrandRepository
    {
        /// <summary>
        /// 关于汽车品牌的显示
        /// </summary>
        /// <returns></returns>
        List<CarTable> GetCarTables(int pid,string brand);
    }
}
