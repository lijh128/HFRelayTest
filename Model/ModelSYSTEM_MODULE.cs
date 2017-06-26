using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//模块功能表
		public class ModelSYSTEM_MODULE
	{
   		     
      	/// <summary>
		/// 功能编号
        /// </summary>		
		private string _f_module_id;
        public string F_MODULE_ID
        {
            get{ return _f_module_id; }
           
            set{ _f_module_id = value; }
        }        
		/// <summary>
		/// 模块名称
        /// </summary>		
		private string _f_module_name;
        public string F_MODULE_NAME
        {
            get{ return _f_module_name; }
           
            set{ _f_module_name = value; }
        }        
		/// <summary>
		/// 模块全称
        /// </summary>		
		private string _f_fullname;
        public string F_FULLNAME
        {
            get{ return _f_fullname; }
           
            set{ _f_fullname = value; }
        }        
		/// <summary>
		/// 父节点代码
        /// </summary>		
		private string _f_parent_module_id;
        public string F_PARENT_MODULE_ID
        {
            get{ return _f_parent_module_id; }
           
            set{ _f_parent_module_id = value; }
        }        
		/// <summary>
		/// 模块行为
        /// </summary>		
		private string _f_action;
        public string F_ACTION
        {
            get{ return _f_action; }
           
            set{ _f_action = value; }
        }        
		/// <summary>
		/// 模块目录
        /// </summary>		
		private string _f_path;
        public string F_PATH
        {
            get{ return _f_path; }
           
            set{ _f_path = value; }
        }        
		/// <summary>
		/// 排序编号
        /// </summary>		
		private decimal _f_ordno;
        public decimal F_ORDNO
        {
            get{ return _f_ordno; }
           
            set{ _f_ordno = value; }
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
		/// 是否只有管理员能执行
        /// </summary>		
		private string _f_isadminonly;
        public string F_ISADMINONLY
        {
            get{ return _f_isadminonly; }
           
            set{ _f_isadminonly = value; }
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

