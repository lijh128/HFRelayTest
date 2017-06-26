using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验准备情况附件
		public class ModelTEST_PREPARE_ATTATCH
	{
   		     
      	/// <summary>
		/// 任务编号
        /// </summary>		
		private string _f_test_task_id;
        public string F_TEST_TASK_ID
        {
            get{ return _f_test_task_id; }
           
            set{ _f_test_task_id = value; }
        }        
		/// <summary>
		/// 附件名称
        /// </summary>		
		private string _f_attatchname;
        public string F_ATTATCHNAME
        {
            get{ return _f_attatchname; }
           
            set{ _f_attatchname = value; }
        }        
		/// <summary>
		/// 附件
        /// </summary>		
		private byte[] _f_attatchment;
        public byte[] F_ATTATCHMENT
        {
            get{ return _f_attatchment; }
           
            set{ _f_attatchment = value; }
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

