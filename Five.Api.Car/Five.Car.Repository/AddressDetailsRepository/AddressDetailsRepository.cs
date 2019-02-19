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
using Five.Car.Command;

namespace Five.Car.Repository
{
    public class AddressDetailsRepository : IAddressDetailsRepository
    {    
        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
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
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = string.Format("insert into Address(UName,Phone,Province,UserAddress) values ('{0}','{1}','{2}','{3}')", addr.UName, addr.Phone, addr.Province,addr.Useraddress);
                int i = conn.Execute(sql);
                return i;
            }
        }

        /// <summary>
        /// 显示地址
        /// </summary>
        /// <returns></returns>
        public List<Address> GetAddress()
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = string.Format("select a.Id,a.UName,a.Phone,a.Province,a.Useraddress,a.State from Address a");
                List<Address> addresslist = conn.Query<Address>(sql).ToList();
                return addresslist;
            }
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Address> GetAddressById(int id)
        {
            using (IDbConnection conn= new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = $"select a.Id,a.UName,a.Phone,a.Province,a.Useraddress,a.State from Address a where a.Id={id} ";
                List<Address> addresslist = conn.Query<Address>(sql).ToList();
                return addresslist;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptAddress(Address addr)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = $"update Address set UName='{addr.UName}',Phone='{addr.Phone}',Province='{addr.Province}',Useraddress='{addr.Useraddress}' Where Id='{addr.Id}'";
                int i = conn.Execute(sql);
                return i;
            }
        }

        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public int UptState(Address addr)
        {
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                string sql = string.Format("update Address set State='{0}' where State=1",0);
                conn.Execute(sql);
                string sqlnew = $"update Address set State='{addr.State}' where Id='{addr.Id}'";
                int i = conn.Execute(sqlnew);
                return i;
            }
        }
    }
}
