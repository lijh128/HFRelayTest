using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//串口设置表
		public class ModelCOM_SETTINGS
	{


      	/// <summary>
		/// 上位机编码
        /// </summary>		
		private string _f_workstation_id;
        public string F_WORKSTATION_ID
        {
            get{ return _f_workstation_id; }
           
            set{ _f_workstation_id = value; }

		   
        }        
		/// <summary>
		/// 串口号
        /// </summary>		
		private string _f_com_code;
        public string F_COM_CODE
        {
            get{ return _f_com_code; }
           
            set{ _f_com_code = value; }
        }        
		/// <summary>
		/// 波特率
        /// </summary>		
		private decimal _f_baudrate;
        public decimal F_BAUDRATE
        {
            get{ return _f_baudrate; }
           
            set{ _f_baudrate = value; }
        }        
		/// <summary>
		/// 数据位
        /// </summary>		
		private decimal _f_databit;
        public decimal F_DATABIT
        {
            get{ return _f_databit; }
           
            set{ _f_databit = value; }
        }        
		/// <summary>
		/// 奇偶校验
        /// </summary>		
		private decimal _f_oddevencheck;
        public decimal F_ODDEVENCHECK
        {
            get{ return _f_oddevencheck; }
           
            set{ _f_oddevencheck = value; }
        }        
		/// <summary>
		/// 停止位
        /// </summary>		
		private decimal _f_stopbit;
        public decimal F_STOPBIT
        {
            get{ return _f_stopbit; }
           
            set{ _f_stopbit = value; }
        }        
		/// <summary>
		/// 类型
        /// </summary>		
		private string _f_type;
        public string F_TYPE
        {
            get{ return _f_type; }
           
            set{ _f_type = value; }
        }        
		/// <summary>
		/// 数据流控制
        /// </summary>		
		private decimal _f_streamcontrol;
        public decimal F_STREAMCONTROL
        {
            get{ return _f_streamcontrol; }
           
            set{ _f_streamcontrol = value; }
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

