using Five.Car.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;
using Dapper;
using System.Data.OracleClient;
using Oracle.Web;
using System.Data;


namespace Five.Car.Repository
{
    public class AddressDetails : IAddressDetails
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public int IAdd(Address addr)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                string sql = string.Format("insert into Address(UName,Phone,UserAddress) values ('{0}','{1}','{2}')", addr.UName, addr.Phone, addr.Useraddress);
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
                string sql = string.Format("select a.UName,a.Phone,a.Useraddress from Address a");
                List<Address> addresslist = conn.Query<Address>(sql).ToList();
                return addresslist;
            }
        }
    }
}
