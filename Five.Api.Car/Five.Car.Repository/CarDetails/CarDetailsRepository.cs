using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;
using Five.Car.IRepository;
using System.Data;
using System.Data.OracleClient;
using Dapper;

namespace Five.Car.Repository
{
    public class CarDetailsRepository : ICarDetailsRepository
    {
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 显示所有的汽车详情
        /// </summary>
        /// <returns></returns>
        public List<CarShop> CarDetailAllShow()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select a.id,a.displacement,a.address,a.price,a.stock,c.colorname,d.series,e.carbrand from Cardetails a join Image b on a.Id=b.carid join Carcolor c on a.carcolorid=c.id join Cartable d on a.brandid=d.id join Cartable e on d.pid=e.id";
                var CarDetail = conn.Query<CarShop>(sql).ToList();
                return CarDetail;
            }
        }

        /// <summary>
        /// 根据Id显示单个的汽车详情
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        public List<CarShop> CarDetailShow(int Pid)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = "select a.id,a.displacement,a.address,a.times,a.price,a.stock,c.colorname,d.series,e.carbrand,a.iscollection,a.details,a.seat,b.imgurl from Cardetails a join Image b on a.Id=b.carid join Carcolor c on a.carcolorid=c.id join Cartable d on a.brandid=d.id join Cartable e on  d.pid=e.id where a.id=" + Pid;
                var CarDetail = conn.Query<CarShop>(sql).ToList();
                return CarDetail;
            }
        }
    }
}
