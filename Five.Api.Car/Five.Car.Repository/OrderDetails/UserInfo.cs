using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.IRepository;
using Five.Car.IRepository.OrderDetails;
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
        /// 根据ID显示汽车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> CarDetail(int id)
        {
            using (IDbConnection conn=new OracleConnection(stron))
            {
                string str= "select a.id,a.displacement,a.address,a.times,a.price,a.stock,c.colorname,d.series,e.carbrand,a.iscollection,a.details,a.seat,b.imgurl from Cardetails a join Image b on a.Id=b.carid join Carcolor c on a.carcolorid=c.id join Cartable d on a.brandid=d.id join Cartable e on  d.pid=e.id where a.id=" + id;
                var carDetails = conn.Query<CarShop>(str).ToList();
                return carDetails;
            }
        }

        /// <summary>
        /// 实现我的单个订单方法
        /// </summary>
        /// <returns></returns>
        public List<OrderCarDetails> CarOrdreTable(int id)
        {
            using (IDbConnection conn= new OracleConnection(stron))
            {
                string str = "select * from Orders join CarDetails on Orders.Carid=CarDetails.Id join Image on CarDetails.Id=Image.Carid where State="+id;
                var carOrdre = conn.Query<OrderCarDetails>(str).ToList();
                return carOrdre;
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
                var carOrdre = conn.Query<OrderCarDetails>(str).ToList();
                return carOrdre;
            }
        }

        /// <summary>
        /// 根据Order ID 显示付款页面信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CarShop> GetOrdersById(int id)
        {
            using (IDbConnection conn=new OracleConnection(stron))
            {
                string str = "select f.id,a.displacement,a.address,a.times,a.price,a.stock,c.colorname,d.series,e.carbrand,a.iscollection,a.details,a.seat,b.imgurl,f.Carid,f.State from Cardetails a join Image b on a.Id = b.carid join Carcolor c on a.carcolorid = c.id join Cartable d on a.brandid = d.id join Cartable e on  d.pid = e.id join Orders f on a.Id = f.carid where f.id =" + id;
                var getOrderById = conn.Query<CarShop>(str).ToList();
                return getOrderById;
            }
        }

        /// <summary>
        /// 付款修改车辆订单状态
        /// </summary>
        public int UpdateCarOrderState(int id)
        {
            using (IDbConnection conn=new OracleConnection(stron))
            {
                string str = string.Format("Update Orders set State=0 where Orders.Id={0}",id);
                var updateOrders = conn.Execute(str);
                return updateOrders;
            }  
        }
    }
}
