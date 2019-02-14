using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.IRepository;
using Five.Car.Model;
using System.Data;
using System.Data.OracleClient;
using Dapper;

namespace Five.Car.Repository
{
    public class UserInfo : IUserInfo
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        private static string stron = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 实现我的订单方法
        /// </summary>
        /// <returns></returns>
        public List<OrderCarDetails> CarOrdreTable()
        {
            using (IDbConnection conn= new OracleConnection(stron))
            {
                string str = "select * from Orders join CarDetails on Orders.Carid=CarDetails.Id join Image on CarDetails.Id=Image.Carid";
                var CarOrdre = conn.Query<OrderCarDetails>(str).ToList();
                return CarOrdre;
            }
        }
    }
}
