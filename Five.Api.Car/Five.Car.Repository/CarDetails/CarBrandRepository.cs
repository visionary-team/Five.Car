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
using Five.Car.Cache;

namespace Five.Car.Repository
{
    public class CarBrandRepository : ICarBrandRepository
    {
        /// <summary>
        /// 显示汽车品牌
        /// </summary>
        /// <returns></returns>
        public List<CarTable> GetCarTables(int pid,string brand)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = $"select * from CarTable where CarBrand like '%{brand}%' and PID={pid}";
                var CarBrands = conn.Query<CarTable>(sql).ToList();
                return CarBrands;
            }
        }       
    }
}
