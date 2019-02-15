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
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";
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
                string sql = string.Format("insert into CarDetails values('{0}','{1}','{2}','{3}','{4}')", details.Carcolorid, details.Displacement, details.Address, details.Price, details.Imgurl);
                int idetails = conn.Execute(sql);
                return idetails;
            }
        }
        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        public List<Address> Address()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select Id,UName,Phone,Province,Useraddress from Address";
                var address = conn.Query<Address>(sql).ToList();
                return address;
            }
        }

        public List<Orders> ShowOrders(string Usersid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select * from Collection a join cardetails b on a.carid=b.id join carcolor c on b.carcolorid=c.id join cartable d on d.id=b.brandid join IMAGE e on b.id=e.carid where userid='{0}'", Usersid);
                var orders = conn.Query<Orders>(sql).ToList();
                return orders;
            }
        }

        public List<Orders> ShowOrders()
        {
            throw new NotImplementedException();
        }
    }
}
