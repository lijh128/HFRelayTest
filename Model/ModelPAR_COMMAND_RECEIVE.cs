using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//接收命令参数元数据表
		public class ModelPAR_COMMAND_RECEIVE
	{
   		     
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
		/// 排列序号
        /// </summary>		
		private decimal _f_receivepar_order;
        public decimal F_RECEIVEPAR_ORDER
        {
            get{ return _f_receivepar_order; }
           
            set{ _f_receivepar_order = value; }
        }        
		/// <summary>
		/// 数据类型
        /// </summary>		
		private string _f_receivepar_data_type;
        public string F_RECEIVEPAR_DATA_TYPE
        {
            get{ return _f_receivepar_data_type; }
           
            set{ _f_receivepar_data_type = value; }
        }        
		/// <summary>
		/// 数据长度
        /// </summary>		
		private decimal _f_receivepar_data_length;
        public decimal F_RECEIVEPAR_DATA_LENGTH
        {
            get{ return _f_receivepar_data_length; }
           
            set{ _f_receivepar_data_length = value; }
        }        
		/// <summary>
		/// 默认参数值
        /// </summary>		
		private string _f_receivepar_default_value;
        public string F_RECEIVEPAR_DEFAULT_VALUE
        {
            get{ return _f_receivepar_default_value; }
           
            set{ _f_receivepar_default_value = value; }
        }        
		/// <summary>
		/// 接收参数单位
        /// </summary>		
		private string _f_receivepar_unit;
        public string F_RECEIVEPAR_UNIT
        {
            get{ return _f_receivepar_unit; }
           
            set{ _f_receivepar_unit = value; }
        }        
		/// <summary>
		/// 是否界面显示
        /// </summary>		
		private decimal _f_receivepar_display;
        public decimal F_RECEIVEPAR_DISPLAY
        {
            get{ return _f_receivepar_display; }
           
            set{ _f_receivepar_display = value; }
        }        
		/// <summary>
		/// 备注
        /// </summary>		
		private string _f_receivepar_memo;
        public string F_RECEIVEPAR_MEMO
        {
            get{ return _f_receivepar_memo; }
           
            set{ _f_receivepar_memo = value; }
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

