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

namespace Five.Car.Repository
{
    public class RotationChartRepository: IRotationChartRepository
    {
<<<<<<< HEAD
        private static string strcon = "Data Source=169.254.104.123/orcl;Persist Security Info=True;User ID=zhubaolinag;pwd=666666";       
=======
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 显示轮播图
        /// </summary>
        /// <returns></returns>
        public List<Rotationchart> ShowRotationchart()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select * from Rotationchart";
                var a= conn.Query<Rotationchart>(sql).ToList();
                return a;
            }
        }
>>>>>>> 8291f69ade6e49d83a4024bc2b73b22e3aea5c32
    }
}
