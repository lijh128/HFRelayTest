using System.Data;

/********************************************************************************
** ����    ��ʷ
** ��ʼʱ�䣺2009-07-16
** ����    ����Ҫ���ڴ�UI�����´��ݴ����ѱ������ݿ�ͨ��,��װ��Connection��Transaction

** ����    ��No.         ����           �޸���                 ����
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{


    public class DBAccess
    {
        private System.Data.OracleClient.OracleTransaction _tns;
        private System.Data.OracleClient.OracleConnection _conn;
        private string _connString;
               
        /// <summary>
        /// �вι��캯��
        /// </summary>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="provider">���ݿ��ṩ������</param>
        public DBAccess(string connectionString)
        {


            _connString = PubConstant.ConnectionString;  //����Util������Ķ������ַ����ķ���������ж���ַ�����ô��߳��
            //���������ַ������ṩ������SqlServer connection����Oracle Connection        
            _conn = new System.Data.OracleClient.OracleConnection(_connString);
            
           
        }


   

        /// <summary>
        /// ������Ӷ���
        /// </summary>
        /// <returns></returns>
        public System.Data.OracleClient.OracleConnection GetConnection
        {
            //�������������֧��һ�������ַ���

            get
            {

                return _conn;
            }


        }

        /// <summary>
        /// �������
        /// </summary>
        public System.Data.OracleClient.OracleTransaction GetTransaction
        {
            get
            {
                return _tns;
            }
        }

        /// <summary>
        /// ��ʼ����
        /// </summary>
        public void BeginTransaction()
        {
            _tns =_conn.BeginTransaction();
        }


        /// <summary>
        /// �ύ����
        /// </summary>
        public void CommitTns()
        {
            _tns.Commit();
        }


        /// <summary>
        /// �ع�����
        /// </summary>
        public void RollBackTns()
        {
            _tns.Rollback();
        }


        /// <summary>
        /// ������
        /// </summary>
        public void ConnectionOpen()
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();
        }

        /// <summary>
        /// �ر�����
        /// </summary>
        public void ConnectionClose()
        {
            
            
            if (_conn.State == ConnectionState.Open)
                _conn.Close();
        }
       

    }
}
