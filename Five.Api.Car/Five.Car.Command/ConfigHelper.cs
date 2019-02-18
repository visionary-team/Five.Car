using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Car.Command
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

    }
}
