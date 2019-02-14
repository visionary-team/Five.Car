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
    public class AddressDetails : IAddressDetails
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";
        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = $"delete from Address where Id={id}";
                int i = conn.Execute(sql);
                return i;
            }
        }
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public int IAdd(Address addr)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("insert into Address(UName,Phone,Province,UserAddress) values ('{0}','{1}','{2}','{3}')", addr.UName, addr.Phone, addr.Province, addr.Useraddress);
                int i = conn.Execute(sql);
                return i;
            }
        }
        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        public List<Address> Show()
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("select a.Id,a.UName,a.Phone,a.Province,a.Useraddress from Address a");
                List<Address> addresslist = conn.Query<Address>(sql).ToList();
                return addresslist;
            }
        }
    }
}
