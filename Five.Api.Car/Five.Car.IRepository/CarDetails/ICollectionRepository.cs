using Five.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.IRepository
{
    public interface ICollectionRepository
    {
        /// <summary>
        /// 根据Id修改车辆是否收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UpdateCarCollection(int id,int isCollection);
    }
}
