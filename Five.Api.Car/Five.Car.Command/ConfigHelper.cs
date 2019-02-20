using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Five.Car.Cache
{
    public class ConfigHelper
    {
        
        public static string ConnString
        {
            get {
                string Connection = System.Configuration.ConfigurationSettings.AppSettings["Connection"];
                return Connection;
            }
        }

        /// <summary>
        /// 自定义获取配置文件中的值
        /// </summary>
        /// <param name="strConfigKey">节点名称</param>
        /// <returns>节点值</returns>
        private static string GetConfigValue(string strConfigKey)
        {
            return ConfigurationManager.AppSettings[strConfigKey];
        }


        private static string _redisServiceUrl = string.Empty;

        /// <summary>
        /// Redis服务器地址 
        /// </summary>
        public static string RedisServiceUrl
        {
            get
            {
                _redisServiceUrl = GetConfigValue("RedisServiceUrl");
                // _redisServiceUrl = ConfigurationManager.AppSettings["RedisServiceUrl"];
                return _redisServiceUrl;
            }
        }

        private static int _redisServicePortNum = 0;

        /// <summary>
        /// Redis服务器端口号
        /// </summary>
        public static int RedisServicePortNum
        {
            get
            {
                _redisServicePortNum = int.Parse(GetConfigValue("RedisServicePortNum"));
                return _redisServicePortNum;
            }
        }
    }
}
