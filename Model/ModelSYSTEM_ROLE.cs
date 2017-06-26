using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//角色表
		public class ModelSYSTEM_ROLE
	{
   		     
      	/// <summary>
		/// 角色编号
        /// </summary>		
		private string _f_role_id;
        public string F_ROLE_ID
        {
            get{ return _f_role_id; }
           
            set{ _f_role_id = value; }
        }        
		/// <summary>
		/// 角色名称
        /// </summary>		
		private string _f_role_name;
        public string F_ROLE_NAME
        {
            get{ return _f_role_name; }
           
            set{ _f_role_name = value; }
        }        
		/// <summary>
		/// 描述
        /// </summary>		
		private string _f_desc;
        public string F_DESC
        {
            get{ return _f_desc; }
           
            set{ _f_desc = value; }
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

