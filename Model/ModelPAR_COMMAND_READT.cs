using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验运行读取参数信息
		public class ModelPAR_COMMAND_READT
	{
   		     
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
		/// 试验程序编码
        /// </summary>		
		private string _f_programm_code;
        public string F_PROGRAMM_CODE
        {
            get{ return _f_programm_code; }
           
            set{ _f_programm_code = value; }
        }        
		/// <summary>
		/// 命令参数id值
        /// </summary>		
		private decimal _f_receivecommand_par_id;
        public decimal F_RECEIVECOMMAND_PAR_ID
        {
            get{ return _f_receivecommand_par_id; }
           
            set{ _f_receivecommand_par_id = value; }
        }        
		/// <summary>
		/// 试验参数项名称
        /// </summary>		
		private string _f_receivepar_name;
        public string F_RECEIVEPAR_NAME
        {
            get{ return _f_receivepar_name; }
           
            set{ _f_receivepar_name = value; }
        }        
		/// <summary>
		/// 排列顺序
        /// </summary>		
		private decimal _f_order;
        public decimal F_ORDER
        {
            get{ return _f_order; }
           
            set{ _f_order = value; }
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

