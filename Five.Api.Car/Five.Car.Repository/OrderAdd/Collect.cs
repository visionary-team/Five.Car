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
                string sql = string.Format("insert into cardetails(brandid,carcolorid,displacement,seat,address,details,stock,price,times,iscollection) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',0)", details.Brandid, details.Carcolorid,details.Displacement,details.Seat,details.Address,details.Details,details.Stock,details.Price,details.Times);

                int i = 1;

                var idetails = conn.Execute(sql);
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
        /// <summary>
        /// 显示车辆详情
        /// </summary>
        /// <param name="Usersid"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 车辆详情下拉
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public List<CarTable> Details()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select Id,Carbrand from CarTable");
                var details = conn.Query<CarTable>(sql).ToList();
                return details;
            }
        }

        /// <summary>
        /// 车辆颜色下拉
        /// </summary>
        /// <returns></returns>
        public List<CarColor> Color()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select Id,Colorname from CarColor");
                var color = conn.Query<CarColor>(sql).ToList();
                return color;
            }
        }
    }
}
