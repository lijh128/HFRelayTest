﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务参数代码值表
		public class ModelTESTTASK_PARVALUE
	{
   		     
      	/// <summary>
		/// 分类代码
        /// </summary>		
		private string _f_type_code;
        public string F_TYPE_CODE
        {
            get{ return _f_type_code; }
           
            set{ _f_type_code = value; }
        }        
		/// <summary>
		/// 参数编号
        /// </summary>		
		private string _f_code;
        public string F_CODE
        {
            get{ return _f_code; }
           
            set{ _f_code = value; }
        }        
		/// <summary>
		/// 参数名称
        /// </summary>		
		private string _f_name;
        public string F_NAME
        {
            get{ return _f_name; }
           
            set{ _f_name = value; }
        }        
		/// <summary>
		/// 描述
        /// </summary>		
		private string _f_description;
        public string F_DESCRIPTION
        {
            get{ return _f_description; }
           
            set{ _f_description = value; }
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

