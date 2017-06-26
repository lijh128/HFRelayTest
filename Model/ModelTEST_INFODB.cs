using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务数据文件
		public class ModelTESINFODB
	{
   		     
      	/// <summary>
		/// 试验任务编号
        /// </summary>		
		private string _f_test_task_id;
        public string F_TEST_TASK_ID
        {
            get{ return _f_test_task_id; }
            set{ _f_test_task_id = value; }
        }        
		/// <summary>
		/// 文件名
        /// </summary>		
		private string _f_test_infodbfilename;
        public string F_TEST_INFODBFILENAME
        {
            get{ return _f_test_infodbfilename; }
            set{ _f_test_infodbfilename = value; }
        }        
		/// <summary>
		/// 任务数据文件
        /// </summary>		
		private byte[] _f_test_infodb;
        public byte[] F_TEST_INFODB
        {
            get{ return _f_test_infodb; }
            set{ _f_test_infodb = value; }
        }        
		/// <summary>
		/// 创建时间
        /// </summary>		
		private DateTime _f_create_time;
        public DateTime F_CREATE_TIME
        {
            get{ return _f_create_time; }
            set{ _f_create_time = value; }
        }        
		/// <summary>
		/// 操作员
        /// </summary>		
		private string _f_operator_id;
        public string F_OPERATOR_ID
        {
            get{ return _f_operator_id; }
            set{ _f_operator_id = value; }
        }        
		/// <summary>
		/// 操作时间
        /// </summary>		
		private DateTime _f_operationtime;
        public DateTime F_OPERATIONTIME
        {
            get{ return _f_operationtime; }
            set{ _f_operationtime = value; }
        }        
		/// <summary>
		/// 是否删除
        /// </summary>		
		private decimal _f_del;
        public decimal F_DEL
        {
            get{ return _f_del; }
            set{ _f_del = value; }
        }        
		   
	}
}

