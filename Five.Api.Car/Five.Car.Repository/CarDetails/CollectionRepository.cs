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
    public class CollectionRepository : ICollectionRepository
    {
        private static string strcon = "Data Source=orcl;User ID=zhubaoliang;pwd=666666";

        /// <summary>
        /// 根据Id修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateCarCollection(int id,int IsCollection)
        {
            using (IDbConnection conn = new OracleConnection(strcon))
            {
                if (IsCollection == 1)
                {
                    string sql = $"update CarDetails set ISCOLLECTION=0 where Id={id}";
                    var i = conn.Execute(sql);
                    string DeleteSql = $"delete from Collection where Carid={id}";
                    var DeleteI = conn.Execute(DeleteSql);
                    return i;
                }
                else if(IsCollection==0){
                    string sql = $"update CarDetails set ISCOLLECTION=1 where Id={id}";
                    var i = conn.Execute(sql);
                    string InsertSql = $"insert into Collection(Carid,Userid,Number1) values({id},'1',1)";
                    var InsertI = conn.Execute(InsertSql);
                    return InsertI;
                }
                return 0;
            }
        }
    }
}
