using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验命令字信息
		public class ModelPAR_COMMAND_INFO
	{
   		     
      	/// <summary>
		/// 试验命令字编号
        /// </summary>		
		private decimal _f_command_id;
        public decimal F_COMMAND_ID
        {
            get{ return _f_command_id; }
           
            set{ _f_command_id = value; }
        }        
		/// <summary>
		/// 命令字描述
        /// </summary>		
		private string _f_command_desc;
        public string F_COMMAND_DESC
        {
            get{ return _f_command_desc; }
           
            set{ _f_command_desc = value; }
        }        
		/// <summary>
		/// 命令字代码
        /// </summary>		
		private string _f_command_code;
        public string F_COMMAND_CODE
        {
            get{ return _f_command_code; }
           
            set{ _f_command_code = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _f_command_memo;
        public string F_COMMAND_MEMO
        {
            get{ return _f_command_memo; }
           
            set{ _f_command_memo = value; }
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

