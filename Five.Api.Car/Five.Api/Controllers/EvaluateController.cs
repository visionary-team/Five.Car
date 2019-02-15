using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Five.Car.IRepository;
using Five.Car.IRepository.IEvaluateDetails;
using Five.Car.Model;

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
    }
}
