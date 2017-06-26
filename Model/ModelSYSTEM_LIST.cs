using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
		public class ModelSYSTEM_LIST
	{
   		     
      	/// <summary>
		/// F_TYPE
        /// </summary>		
		private string _f_type;
        public string F_TYPE
        {
            get{ return _f_type; }
           
            set{ _f_type = value; }
        }        
		/// <summary>
		/// F_VALUE
        /// </summary>		
		private decimal _f_value;
        public decimal F_VALUE
        {
            get{ return _f_value; }
           
            set{ _f_value = value; }
        }        
		/// <summary>
		/// F_DISPLAY
        /// </summary>		
		private string _f_display;
        public string F_DISPLAY
        {
            get{ return _f_display; }
           
            set{ _f_display = value; }
        }        
		   
	}
}

