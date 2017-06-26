using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务样品信息
		public class ModelTEST_SAMPLE_INFO
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
		/// 样品数量
        /// </summary>		
		private decimal _f_sample_num;
        public decimal F_SAMPLE_NUM
        {
            get{ return _f_sample_num; }
           
            set{ _f_sample_num = value; }
        }        
		/// <summary>
		/// 样品组别
        /// </summary>		
		private string _f_sample_group_num;
        public string F_SAMPLE_GROUP_NUM
        {
            get{ return _f_sample_group_num; }
           
            set{ _f_sample_group_num = value; }
        }        
		/// <summary>
		/// 其他信息
        /// </summary>		
		private string _f_sample_memo;
        public string F_SAMPLE_MEMO
        {
            get{ return _f_sample_memo; }
           
            set{ _f_sample_memo = value; }
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

