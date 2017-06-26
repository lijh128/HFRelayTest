using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//线圈电源状态转换流水
		public class ModelFLOW_COIL_STATUS
	{
   		     
      	/// <summary>
		/// 流水号
        /// </summary>		
		private decimal _f__id;
        public decimal F__ID
        {
            get{ return _f__id; }
           
            set{ _f__id = value; }
        }        
		/// <summary>
		/// 线圈电源标识编号
        /// </summary>		
		private string _f_coilpower_id;
        public string F_COILPOWER_ID
        {
            get{ return _f_coilpower_id; }
           
            set{ _f_coilpower_id = value; }
        }        
		/// <summary>
		/// 线圈电源名称
        /// </summary>		
		private string _f_coilpower_name;
        public string F_COILPOWER_NAME
        {
            get{ return _f_coilpower_name; }
           
            set{ _f_coilpower_name = value; }
        }        
		/// <summary>
		/// 线圈电源开关状态
        /// </summary>		
		private decimal _f_coilpower_switch_status;
        public decimal F_COILPOWER_SWITCH_STATUS
        {
            get{ return _f_coilpower_switch_status; }
           
            set{ _f_coilpower_switch_status = value; }
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

