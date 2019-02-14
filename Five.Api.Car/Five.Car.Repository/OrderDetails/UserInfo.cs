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
using Five.Car.IRepository.OrderDetails;

namespace Five.Car.Repository
{
    public class UserInfo : IUserInfo
    {
        /// <summary>
        /// 连接数据库
        /// </summary>
        private static string stron = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 实现我的单个订单方法
        /// </summary>
        /// <returns></returns>
        public List<OrderCarDetails> CarOrdreTable(int id)
        {
            using (IDbConnection conn= new OracleConnection(stron))
            {
                string str = "select * from Orders join CarDetails on Orders.Carid=CarDetails.Id join Image on CarDetails.Id=Image.Carid where State="+id;
                var CarOrdre = conn.Query<OrderCarDetails>(str).ToList();
                return CarOrdre;
            }
        }
        /// <summary>
        /// 实现全部订单
        /// </summary>
        /// <returns></returns>
        public List<OrderCarDetails> CarOrdreTableAll()
        {
            using (IDbConnection conn = new OracleConnection(stron))
            {
                string str = "select * from Orders join CarDetails on Orders.Carid=CarDetails.Id join Image on CarDetails.Id=Image.Carid";
                var CarOrdre = conn.Query<OrderCarDetails>(str).ToList();
                return CarOrdre;
            }
        }
    }
}
