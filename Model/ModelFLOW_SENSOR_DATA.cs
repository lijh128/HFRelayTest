﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//温度传感器监测流水信息
		public class ModelFLOW_SENSOR_DATA
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
		/// 温度传感器编号
        /// </summary>		
		private string _f_sensor_id;
        public string F_SENSOR_ID
        {
            get{ return _f_sensor_id; }
           
            set{ _f_sensor_id = value; }
        }        
		/// <summary>
		/// 温度值
        /// </summary>		
		private decimal _f_sendor_value;
        public decimal F_SENDOR_VALUE
        {
            get{ return _f_sendor_value; }
           
            set{ _f_sendor_value = value; }
        }        
		/// <summary>
		/// 采集时间
        /// </summary>		
		private DateTime _f_sensor_value_time;
        public DateTime F_SENSOR_VALUE_TIME
        {
            get{ return _f_sensor_value_time; }
           
            set{ _f_sensor_value_time = value; }
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

