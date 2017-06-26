using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//下位机与负载柜关系
		public class ModelDEV_LOAD_TO_SUB
	{
   		     
      	/// <summary>
		/// 下位机编号
        /// </summary>		
		private string _f_subordinate_id;
        public string F_SUBORDINATE_ID
        {
            get{ return _f_subordinate_id; }
           
            set{ _f_subordinate_id = value; }
        }        
		/// <summary>
		/// 下位机名称
        /// </summary>		
		private string _f_subordinate_name;
        public string F_SUBORDINATE_NAME
        {
            get{ return _f_subordinate_name; }
           
            set{ _f_subordinate_name = value; }
        }        
		/// <summary>
		/// 负载柜编号
        /// </summary>		
		private string _f_load_id;
        public string F_LOAD_ID
        {
            get{ return _f_load_id; }
           
            set{ _f_load_id = value; }
        }        
		/// <summary>
		/// 负载柜名称
        /// </summary>		
		private string _f_load_name;
        public string F_LOAD_NAME
        {
            get{ return _f_load_name; }
           
            set{ _f_load_name = value; }
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

