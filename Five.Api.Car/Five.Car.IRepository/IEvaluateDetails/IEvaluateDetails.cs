using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository.IEvaluateDetails
{
    public interface IEvaluateDetails
    {
        /// <summary>
        /// 评论显示
        /// </summary>
        /// <returns></returns>
        List<Evaluate> Show();
    }
}
