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
using Five.Car.Command;

namespace Five.Car.Repository
{
    public class CollectionRepository : ICollectionRepository
    {
        /// <summary>
        /// 根据Id修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateCarCollection(int id,int isCollection)
        {
            int i = 0;
            using (IDbConnection conn = new OracleConnection(ConfigHelper.ConnString))
            {
                if (isCollection == 1)
                {
                    string sql = $"update CarDetails set ISCOLLECTION=0 where Id={id}";
                    i = conn.Execute(sql);
                    sql = $"delete from Collection where Carid={id}";
                    i = conn.Execute(sql);
                }
                else if(isCollection==0){
                    string sql = $"update CarDetails set ISCOLLECTION=1 where Id={id}";
                    i = conn.Execute(sql);
                    sql = $"insert into Collection(Carid,Userid,Number1) values({id},'1',1)";
                    i = conn.Execute(sql);
                }
            }
            return i;
        }
    }
}
