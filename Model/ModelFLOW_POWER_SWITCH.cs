using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//供电柜开关状态转换流水
		public class ModelFLOW_POWER_SWITCH
	{
   		     
      	/// <summary>
		/// 状态转换流水号
        /// </summary>		
		private decimal _f_id;
        public decimal F_ID
        {
            get{ return _f_id; }
           
            set{ _f_id = value; }
        }        
		/// <summary>
		/// 供电柜编号
        /// </summary>		
		private string _f_power_id;
        public string F_POWER_ID
        {
            get{ return _f_power_id; }
           
            set{ _f_power_id = value; }
        }        
		/// <summary>
		/// 开关序号
        /// </summary>		
		private string _f_power_switch_id;
        public string F_POWER_SWITCH_ID
        {
            get{ return _f_power_switch_id; }
           
            set{ _f_power_switch_id = value; }
        }        
		/// <summary>
		/// 开关状态
        /// </summary>		
		private decimal _f_power_status;
        public decimal F_POWER_STATUS
        {
            get{ return _f_power_status; }
           
            set{ _f_power_status = value; }
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

