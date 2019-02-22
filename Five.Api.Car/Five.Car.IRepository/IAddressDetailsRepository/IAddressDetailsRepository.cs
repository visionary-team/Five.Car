using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository
{
   public interface IAddressDetailsRepository
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        int IAdd(Address addr);

        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        List<Address> GetAddress(string userId);

        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Address> GetAddressById(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int UptAddress(Address addr);

        
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        int UptState(Address addr);


    }
}
