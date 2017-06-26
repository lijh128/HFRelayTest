using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//负载电源与供电柜开关关系
		public class ModelDEV_LOADPOW_TO_SWITCH
	{
   		     
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
		/// 负载电源编号
        /// </summary>		
		private string _f_loadpower_id;
        public string F_LOADPOWER_ID
        {
            get{ return _f_loadpower_id; }
           
            set{ _f_loadpower_id = value; }
        }        
		/// <summary>
		/// 负载电源名称
        /// </summary>		
		private string _f_loadpower_name;
        public string F_LOADPOWER_NAME
        {
            get{ return _f_loadpower_name; }
           
            set{ _f_loadpower_name = value; }
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

