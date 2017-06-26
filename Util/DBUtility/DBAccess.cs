using System.Data;

/********************************************************************************
** 作者    ：史
** 创始时间：2009-07-16
** 描述    ：主要用于从UI层向下传递此类已便与数据库通信,封装了Connection和Transaction

** 履历    ：No.         日期           修改人                 描述
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{


    public class DBAccess
    {
        private System.Data.OracleClient.OracleTransaction _tns;
        private System.Data.OracleClient.OracleConnection _conn;
        private string _connString;
               
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="provider">数据库提供者名称</param>
        public DBAccess(string connectionString)
        {


            _connString = PubConstant.ConnectionString;  //调用Util工具类的读连接字符串的方法，如果有多个字符串怎么办叱？
            //根据连接字符串的提供者生成SqlServer connection或是Oracle Connection        
            _conn = new System.Data.OracleClient.OracleConnection(_connString);
            
           
        }


   

        /// <summary>
        /// 获得连接对象
        /// </summary>
        /// <returns></returns>
        public System.Data.OracleClient.OracleConnection GetConnection
        {
            //现在这个方法仅支持一个连接字符串

            get
            {

                return _conn;
            }


        }

        /// <summary>
        /// 获得事务
        /// </summary>
        public System.Data.OracleClient.OracleTransaction GetTransaction
        {
            get
            {
                return _tns;
            }
        }

        /// <summary>
        /// 开始事务
        /// </summary>
        public void BeginTransaction()
        {
            _tns =_conn.BeginTransaction();
        }


        /// <summary>
        /// 提交事务
        /// </summary>
        public void CommitTns()
        {
            _tns.Commit();
        }


        /// <summary>
        /// 回滚事务
        /// </summary>
        public void RollBackTns()
        {
            _tns.Rollback();
        }


        /// <summary>
        /// 打开连接
        /// </summary>
        public void ConnectionOpen()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void ConnectionClose()
        {
            
            
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }
       

    }
}
