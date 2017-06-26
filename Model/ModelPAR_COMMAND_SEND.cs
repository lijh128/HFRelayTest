using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//发送命令参数元数据表
		public class ModelPAR_COMMAND_SEND
	{
   		     
      	/// <summary>
		/// 命令参数id值
        /// </summary>		
		private decimal _f_sendcommand_par_id;
        public decimal F_SENDCOMMAND_PAR_ID
        {
            get{ return _f_sendcommand_par_id; }
           
            set{ _f_sendcommand_par_id = value; }
        }        
		/// <summary>
		/// 试验参数项名称
        /// </summary>		
		private string _f_sendpar_name;
        public string F_SENDPAR_NAME
        {
            get{ return _f_sendpar_name; }
           
            set{ _f_sendpar_name = value; }
        }        
		/// <summary>
		/// 排列序号
        /// </summary>		
		private decimal _f_sendpar_order;
        public decimal F_SENDPAR_ORDER
        {
            get{ return _f_sendpar_order; }
           
            set{ _f_sendpar_order = value; }
        }        
		/// <summary>
		/// 数据类型
        /// </summary>		
		private string _f_sendpar_data_type;
        public string F_SENDPAR_DATA_TYPE
        {
            get{ return _f_sendpar_data_type; }
           
            set{ _f_sendpar_data_type = value; }
        }        
		/// <summary>
		/// 数据长度
        /// </summary>		
		private decimal _f_sendpar_data_length;
        public decimal F_SENDPAR_DATA_LENGTH
        {
            get{ return _f_sendpar_data_length; }
           
            set{ _f_sendpar_data_length = value; }
        }        
		/// <summary>
		/// 默认参数值
        /// </summary>		
		private string _f_sendpar_default_value;
        public string F_SENDPAR_DEFAULT_VALUE
        {
            get{ return _f_sendpar_default_value; }
           
            set{ _f_sendpar_default_value = value; }
        }        
		/// <summary>
		/// 下发参数单位
        /// </summary>		
		private string _f_sendpar_unit;
        public string F_SENDPAR_UNIT
        {
            get{ return _f_sendpar_unit; }
           
            set{ _f_sendpar_unit = value; }
        }        
		/// <summary>
		/// 参数设置位置
        /// </summary>		
		private decimal _f_sendpar_set;
        public decimal F_SENDPAR_SET
        {
            get{ return _f_sendpar_set; }
           
            set{ _f_sendpar_set = value; }
        }        
		/// <summary>
		/// 是否界面显示
        /// </summary>		
		private decimal _f_sendpar_display;
        public decimal F_SENDPAR_DISPLAY
        {
            get{ return _f_sendpar_display; }
           
            set{ _f_sendpar_display = value; }
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

