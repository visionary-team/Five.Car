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
using Five.Car.Command;

namespace Five.Car.Repository.EvaluateDetails
{
    public class EvaluateDetailsRepository : IEvaluateDetailsRepository
    {
        /// <summary>
        /// 显示详情
        /// </summary>
        /// <returns></returns>
        public List<CarDetails> GetCarDetails()
        {
            using (IDbConnection conn= new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = "select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price from Carcolor a,cardetails b,Image c,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and b.Id=1";
                List<CarDetails> getcardetails = conn.Query<CarDetails>(sql).ToList();
                return getcardetails;
            }
        }

        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public int Add(Evaluate eval)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = $"insert into Evaluate(Content,Isdelete,State,CarDetailsId) values('{eval.Content}','{eval.Isdelete}','{eval.State}','{eval.CarDetailsId}')";
                int i = conn.Execute(sql);
                return i;
            }
        }

        /// <summary>
        /// 评价显示
        /// </summary>
        /// <returns></returns>
        public List<Evaluate> GetEvaluates(int num)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = "";
                switch (num)
                {
                    case 0:
                        sql = $"select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price,d.content,d.State from Carcolor a,cardetails b,Image c,Evaluate d,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and d.CarDetailsId=b.Id";
                        break;
                    case 1:
                        sql = $"select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price,d.content,d.State from Carcolor a,cardetails b,Image c,Evaluate d,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and d.CarDetailsId=b.Id and d.State='{"好评"}'";
                        break;
                    case 2:
                        sql = $"select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price,d.content,d.State from Carcolor a,cardetails b,Image c,Evaluate d,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and d.CarDetailsId=b.Id and d.State='{"中评"}'";
                        break;
                    case 3:
                        sql = $"select b.Id,c.imgurl,e.carbrand,a.colorname,b.displacement,b.price,d.content,d.State from Carcolor a,cardetails b,Image c,Evaluate d,CarTable e where a.id=b.carcolorid and c.CarId=b.id and e.Id=b.brandid and d.CarDetailsId=b.Id and d.State='{"差评"}'";
                        break;
                }
  
                List<Evaluate> getevaluate = conn.Query<Evaluate>(sql).ToList();
                return getevaluate;
            }
        }

        public List<Evaluate> GetEvaluatesById(int id)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = "select * from Evaluate where CARDETAILSID=" + id;
                List<Evaluate> getevaluates = conn.Query<Evaluate>(sql).ToList();
                return getevaluates;
            }
        }
    }
}
