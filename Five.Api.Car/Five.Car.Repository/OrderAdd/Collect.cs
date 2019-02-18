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
    public class Collect : ICollect
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
<<<<<<< HEAD
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";//47
        public List<Collection> ShowCollection(string Usersid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select * from Collection a join cardetails b on a.carid=b.id join carcolor c on b.carcolorid=c.id join cartable d on d.id=b.brandid join IMAGE e on b.id=e.carid where userid='{0}'", Usersid);
                var collection = conn.Query<Collection>(sql).ToList();
                return collection;
            }
        }
        /// <summary>
        /// 发布车源
        /// </summary>
        /// <param name="details"></param>
        /// <returns></returns>
        public int AddCarDetails(CarDetails details)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("insert into CarDetails values('{0}','{1}','{2}','{3}','{4}')", details.Brandid, details.Carcolorid, details.Displacement, details.Address, details.Price);
=======
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";
>>>>>>> 89630baeee8aaa8603c4942573a3cbf7df480e31

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
        public List<Collection> ShowCollection(string Usersid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select * from Collection a join cardetails b on a.carid=b.id join carcolor c on b.carcolorid=c.id join cartable d on d.id=b.brandid join IMAGE e on b.id=e.carid where userid='{0}'", Usersid);
                var a = conn.Query<Collection>(sql).ToList();
                return a;
                var orders = conn.Query<Orders>(sql).ToList();
                return orders;
            }
        }

        public int AddCarDetails(CarDetails c)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
<<<<<<< HEAD
                string sql = string.Format("select Id,Carbrand from CarTable");//44
                var details = conn.Query<CarTable>(sql).ToList();
                return details;
=======
                string sql = string.Format("insert into CarDetails values('{0}','{1}','{2}','{3}','{4}')", c.Carcolorid, c.Displacement, c.Address, c.Price, c.Imgurl);
                int i = conn.Execute(sql);
                return i;
>>>>>>> 89630baeee8aaa8603c4942573a3cbf7df480e31
            }
        }

        public int Add(CarDetails carDetails)
        {
            throw new NotImplementedException();
        }
    }
}
