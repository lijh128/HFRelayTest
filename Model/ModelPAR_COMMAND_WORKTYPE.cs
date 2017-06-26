using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//工作模式试验程序信息表
		public class ModelPAR_COMMAND_WORKTYPE
	{
   		     
      	/// <summary>
		/// 唯一序号
        /// </summary>		
		private decimal _f_id;
        public decimal F_ID
        {
            get{ return _f_id; }
           
            set{ _f_id = value; }
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
		/// 工作模式代码
        /// </summary>		
		private string _f_worktype_code;
        public string F_WORKTYPE_CODE
        {
            get{ return _f_worktype_code; }
           
            set{ _f_worktype_code = value; }
        }        
		/// <summary>
		/// 试验程序编码
        /// </summary>		
		private string _f_programm_code;
        public string F_PROGRAMM_CODE
        {
            get{ return _f_programm_code; }
           
            set{ _f_programm_code = value; }
        }        
		/// <summary>
		/// 试验程序说明
        /// </summary>		
		private string _f_programm_desc;
        public string F_PROGRAMM_DESC
        {
            get{ return _f_programm_desc; }
           
            set{ _f_programm_desc = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _f_worktype_memo;
        public string F_WORKTYPE_MEMO
        {
            get{ return _f_worktype_memo; }
           
            set{ _f_worktype_memo = value; }
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

