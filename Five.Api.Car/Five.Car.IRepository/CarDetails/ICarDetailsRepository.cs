using System;
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
        /// 关于汽车详情的显示
        /// </summary>
        /// <returns></returns>
        List<CarDetails> CarDetailShow(int Pid);
    }
}
