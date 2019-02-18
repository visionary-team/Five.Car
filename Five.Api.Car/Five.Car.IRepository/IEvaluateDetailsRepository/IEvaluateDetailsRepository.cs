using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository.IEvaluateDetails
{
    public interface IEvaluateDetailsRepository
    {
        /// <summary>
        /// 评论显示
        /// </summary>
        /// <returns></returns>
        List<Evaluate> GetEvaluates();

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        int Add(Evaluate eval);


        /// <summary>
        /// 获取汽车详情
        /// </summary>
        /// <returns></returns>
        List<CarDetails> GetCarDetails();
    }
}
