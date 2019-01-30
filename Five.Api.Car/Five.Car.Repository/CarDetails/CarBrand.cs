using Five.Car.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;
using System.Data;
using System.Data.OracleClient;
using Dapper;

namespace Five.Car.Repository
{
    public class CarBrand : ICarBrand
    {
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Cars> CarBrandShow(int Pid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select * from CarTable where Pid="+Pid;
                var CarBrands = conn.Query<Cars>(sql).ToList();
                return CarBrands;
            }
        }       
    }
}
