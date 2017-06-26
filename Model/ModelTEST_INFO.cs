using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务基础数据
		public class ModelTEST_INFO
	{
   		     
      	/// <summary>
		/// 试验任务编号
        /// </summary>		
		private string _f_test_task_id;
        public string F_TEST_TASK_ID
        {
            get{ return _f_test_task_id; }
           
            set{ _f_test_task_id = value; }
        }        
		/// <summary>
		/// 检测项目
        /// </summary>		
		private string _f_test_item;
        public string F_TEST_ITEM
        {
            get{ return _f_test_item; }
           
            set{ _f_test_item = value; }
        }        
		/// <summary>
		/// 规格型号
        /// </summary>		
		private string _f_test_model;
        public string F_TEST_MODEL
        {
            get{ return _f_test_model; }
           
            set{ _f_test_model = value; }
        }        
		/// <summary>
		/// 检测标准
        /// </summary>		
		private string _f_test_standard;
        public string F_TEST_STANDARD
        {
            get{ return _f_test_standard; }
           
            set{ _f_test_standard = value; }
        }        
		/// <summary>
		/// 检测性质
        /// </summary>		
		private string _f_test_property;
        public string F_TEST_PROPERTY
        {
            get{ return _f_test_property; }
           
            set{ _f_test_property = value; }
        }        
		/// <summary>
		/// 检测目的
        /// </summary>		
		private string _f_test_aim;
        public string F_TEST_AIM
        {
            get{ return _f_test_aim; }
           
            set{ _f_test_aim = value; }
        }        
		/// <summary>
		/// 委托单位
        /// </summary>		
		private string _f_task_depute_unit;
        public string F_TASK_DEPUTE_UNIT
        {
            get{ return _f_task_depute_unit; }
           
            set{ _f_task_depute_unit = value; }
        }        
		/// <summary>
		/// 联系人
        /// </summary>		
		private string _f_contact;
        public string F_CONTACT
        {
            get{ return _f_contact; }
           
            set{ _f_contact = value; }
        }        
		/// <summary>
		/// 电话
        /// </summary>		
		private string _f_phone;
        public string F_PHONE
        {
            get{ return _f_phone; }
           
            set{ _f_phone = value; }
        }        
		/// <summary>
		/// email
        /// </summary>		
		private string _f_email;
        public string F_EMAIL
        {
            get{ return _f_email; }
           
            set{ _f_email = value; }
        }        
		/// <summary>
		/// 项目负责人
        /// </summary>		
		private string _f_test_charge;
        public string F_TEST_CHARGE
        {
            get{ return _f_test_charge; }
           
            set{ _f_test_charge = value; }
        }        
		/// <summary>
		/// 委托日期
        /// </summary>		
		private DateTime _f_task_depute_date;
        public DateTime F_TASK_DEPUTE_DATE
        {
            get{ return _f_task_depute_date; }
           
            set{ _f_task_depute_date = value; }
        }        
		/// <summary>
		/// 样品系列
        /// </summary>		
		private string _f_test_series;
        public string F_TEST_SERIES
        {
            get{ return _f_test_series; }
           
            set{ _f_test_series = value; }
        }        
		/// <summary>
		/// 样品类别
        /// </summary>		
		private string _f_sample_type;
        public string F_SAMPLE_TYPE
        {
            get{ return _f_sample_type; }
           
            set{ _f_sample_type = value; }
        }        
		/// <summary>
		/// 序列试验
        /// </summary>		
		private decimal _f_sequence_test;
        public decimal F_SEQUENCE_TEST
        {
            get{ return _f_sequence_test; }
           
            set{ _f_sequence_test = value; }
        }        
		/// <summary>
		/// 试验状态
        /// </summary>		
		private decimal _f_test_status;
        public decimal F_TEST_STATUS
        {
            get{ return _f_test_status; }
           
            set{ _f_test_status = value; }
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

