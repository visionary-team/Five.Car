using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.IRepository;
using System.Data.SqlClient;
using Five.Car.Model;
using System.Data;
using Dapper;
using System.Data.OracleClient;
using Five.Car.Command;

namespace Five.Car.Repository
{
    public class RotationChartRepository: IRotationChartRepository
    {
        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Rotationchart> GetRotationcharts()
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = "select * from Rotationchart";
                var Rotations= conn.Query<Rotationchart>(sql).ToList();
                return Rotations;
            }
        }
    }
}
