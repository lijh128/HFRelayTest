using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//操作履历表
		public class ModelOPERATIONLOG
	{
   		     
      	/// <summary>
		/// 编号
        /// </summary>		
		private decimal _f_id;
        public decimal F_ID
        {
            get{ return _f_id; }
           
            set{ _f_id = value; }
        }        
		/// <summary>
		/// 操作日期
        /// </summary>		
		private DateTime _f_date;
        public DateTime F_DATE
        {
            get{ return _f_date; }
           
            set{ _f_date = value; }
        }        
		/// <summary>
		/// 操作人
        /// </summary>		
		private string _f_user_id;
        public string F_USER_ID
        {
            get{ return _f_user_id; }
           
            set{ _f_user_id = value; }
        }        
		/// <summary>
		/// 操作内容
        /// </summary>		
		private string _f_module_name;
        public string F_MODULE_NAME
        {
            get{ return _f_module_name; }
           
            set{ _f_module_name = value; }
        }        
		   
	}
}

