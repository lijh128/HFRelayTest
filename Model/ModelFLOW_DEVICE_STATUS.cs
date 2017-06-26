using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验设备状态转换流水
		public class ModelFLOW_DEVICE_STATUS
	{
   		     
      	/// <summary>
		/// 序列编码
        /// </summary>		
		private decimal _f_id;
        public decimal F_ID
        {
            get{ return _f_id; }
           
            set{ _f_id = value; }
        }        
		/// <summary>
		/// 试验设备类型
        /// </summary>		
		private decimal _f_dev_type;
        public decimal F_DEV_TYPE
        {
            get{ return _f_dev_type; }
           
            set{ _f_dev_type = value; }
        }        
		/// <summary>
		/// 试验设备编号
        /// </summary>		
		private string _f_dev_code;
        public string F_DEV_CODE
        {
            get{ return _f_dev_code; }
           
            set{ _f_dev_code = value; }
        }        
		/// <summary>
		/// 设备状态
        /// </summary>		
		private decimal _f_dev_status;
        public decimal F_DEV_STATUS
        {
            get{ return _f_dev_status; }
           
            set{ _f_dev_status = value; }
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

