using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务运行情况参数值记录
		public class ModelTEST_READVALUE
	{
   		     
      	/// <summary>
		/// 试验任务编号
        /// </summary>		
		private string _f_task_id;
        public string F_TASK_ID
        {
            get{ return _f_task_id; }
           
            set{ _f_task_id = value; }
        }        
		/// <summary>
		/// 样品编号
        /// </summary>		
		private string _f_sample_id;
        public string F_SAMPLE_ID
        {
            get{ return _f_sample_id; }
           
            set{ _f_sample_id = value; }
        }        
		/// <summary>
		/// 参数名称
        /// </summary>		
		private string _f_receivepar_name;
        public string F_RECEIVEPAR_NAME
        {
            get{ return _f_receivepar_name; }
           
            set{ _f_receivepar_name = value; }
        }        
		/// <summary>
		/// 参数值
        /// </summary>		
		private string _f_receivepar_value;
        public string F_RECEIVEPAR_VALUE
        {
            get{ return _f_receivepar_value; }
           
            set{ _f_receivepar_value = value; }
        }        
		/// <summary>
		/// 试验数据读取批次序号
        /// </summary>		
		private decimal _f_readbatch;
        public decimal F_READBATCH
        {
            get{ return _f_readbatch; }
           
            set{ _f_readbatch = value; }
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

