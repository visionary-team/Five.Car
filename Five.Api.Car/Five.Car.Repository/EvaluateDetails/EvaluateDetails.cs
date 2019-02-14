using Five.Car.IRepository.IEvaluateDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace Five.Car.Repository.EvaluateDetails
{
    public class EvaluateDetails : IEvaluateDetails
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";


        /// <summary>
        /// 评价显示
        /// </summary>
        /// <returns></returns>
        public List<Evaluate> Show()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price,d.content from Carcolor a,cardetails b,Image c,Evaluate d,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and d.CarDetailsId=b.Id";
                List<Evaluate> showevaluate = conn.Query<Evaluate>(sql).ToList();
                return showevaluate;
            }
        }
    }
}
