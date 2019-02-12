using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;
using Five.Car.IRepository;
using System.Data;
using System.Data.OracleClient;
using Dapper;

namespace Five.Car.Repository
{
    public class CarDetailsRepository : ICarDetailsRepository
    {
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 关于汽车详情的显示
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public List<CarDetails> CarDetailShow(int Pid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select * from CARDETAILS where Id=" + Pid;
                var CarDetail = conn.Query<CarDetails>(sql).ToList();
                return CarDetail;
            }
        }
    }
}
