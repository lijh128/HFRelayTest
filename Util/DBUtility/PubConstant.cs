using System.Configuration;

namespace RelayTest.Util.DBUtility
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];       
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    //_connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                //_connectionString = "Persist Security Info=True;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.28.31.79)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=SPD)));User Id=xkspd;Password=xkspd;";
                //_connectionString = "Persist Security Info=True;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=172.28.26.53)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XKSPD)));User Id=XKSPD01;Password=XKSPD;Enlist=false";
                //Data Source=XKSPD;User ID=XKSPD01;password=XKSPD;Enlist=false";
                //"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.250)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=spd)));User Id=xkspd;Password=xkspd;";
                return _connectionString; 
            }
        }


        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string AccessConnectionString
        {
            get
            {
                //当前路径
                //string path = System.AppDomain.CurrentDomain.BaseDirectory;
                //path = System.IO.Path.GetFullPath(path);

                //string _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "\\DataFile\\15071700101.mdb;Persist Security Info=False";
                string _connectionString=ConfigurationManager.AppSettings["ConnectionStringAccess"];
                return _connectionString;
            }

            
        }


        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                //connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
