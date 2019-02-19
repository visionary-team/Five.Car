using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.IRepository.IEvaluateDetails;
using Five.Car.Model;
using System.Web;

namespace Five.Api.Controllers
{
    public class EvaluateController : ApiController
    {

        public IEvaluateDetailsRepository evaluateDetails { get; set; }

        /// <summary>
        /// 显示评价
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Evaluate> GetEvaluates()
        {
            List<Evaluate> Evaluatelist = evaluateDetails.GetEvaluates();
            return Evaluatelist;
        }

        /// <summary>
        /// 显示汽车详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CarDetails> GetCarDetails()
        {
            List<CarDetails> CarDetailsList = evaluateDetails.GetCarDetails();
            return CarDetailsList;
    
        }

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int Add()
        {
            Evaluate eval = new Evaluate();//实例化
            eval.Content = HttpContext.Current.Request["Content"];
            eval.Isdelete = Convert.ToInt32(HttpContext.Current.Request["Isdelete"]);
            eval.State = HttpContext.Current.Request["State"];
            eval.CarDetailsId = Convert.ToInt32(HttpContext.Current.Request["CarDetailsId"]);
            int i = evaluateDetails.Add(eval);
            return i;
        }

        /// <summary>
        /// 通过id获取评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Evaluate> GetEvaluatesById(int id)
        {
            var evaluates = evaluateDetails.GetEvaluatesById(id);
            return evaluates;
        }
    }
}
