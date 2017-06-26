using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验初始命令参数值表上位机
		public class ModelTEST_PAR_VALUE_SWJ
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
		/// 工作模式名称
        /// </summary>		
		private string _f_worktype_name;
        public string F_WORKTYPE_NAME
        {
            get{ return _f_worktype_name; }
           
            set{ _f_worktype_name = value; }
        }        
		/// <summary>
		/// 工作模式编码
        /// </summary>		
		private string _f_worktype_code;
        public string F_WORKTYPE_CODE
        {
            get{ return _f_worktype_code; }
           
            set{ _f_worktype_code = value; }
        }        
		/// <summary>
		/// 程序代码
        /// </summary>		
		private string _f_program_code;
        public string F_PROGRAM_CODE
        {
            get{ return _f_program_code; }
           
            set{ _f_program_code = value; }
        }        
		/// <summary>
		/// 参数名称
        /// </summary>		
		private string _f_sendpar_name;
        public string F_SENDPAR_NAME
        {
            get{ return _f_sendpar_name; }
           
            set{ _f_sendpar_name = value; }
        }        
		/// <summary>
		/// 参数值
        /// </summary>		
		private string _f_sendpar_value;
        public string F_SENDPAR_VALUE
        {
            get{ return _f_sendpar_value; }
           
            set{ _f_sendpar_value = value; }
        }        
		/// <summary>
		/// 排序序号
        /// </summary>		
		private decimal _f_sendorder;
        public decimal F_SENDORDER
        {
            get{ return _f_sendorder; }
           
            set{ _f_sendorder = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _f_sendpar_memo;
        public string F_SENDPAR_MEMO
        {
            get{ return _f_sendpar_memo; }
           
            set{ _f_sendpar_memo = value; }
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

