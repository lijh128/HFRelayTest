using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验准备情况记录
		public class ModelTEST_PREPARE
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
		/// 参数设置是否正确
        /// </summary>		
		private decimal _f_isparok;
        public decimal F_ISPAROK
        {
            get{ return _f_isparok; }
           
            set{ _f_isparok = value; }
        }        
		/// <summary>
		/// 确认时间
        /// </summary>		
		private DateTime _f_test_time;
        public DateTime F_TEST_TIME
        {
            get{ return _f_test_time; }
           
            set{ _f_test_time = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _f_memo;
        public string F_MEMO
        {
            get{ return _f_memo; }
           
            set{ _f_memo = value; }
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

