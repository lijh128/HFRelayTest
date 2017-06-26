using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//试验任务分配及运行情况记录
		public class ModelTEST_ALLOCATION
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
		/// 样品编号
        /// </summary>		
		private string _f_test_sample_id;
        public string F_TEST_SAMPLE_ID
        {
            get{ return _f_test_sample_id; }
           
            set{ _f_test_sample_id = value; }
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
		/// 负载通道编号
        /// </summary>		
		private string _f_load_channel_id;
        public string F_LOAD_CHANNEL_ID
        {
            get{ return _f_load_channel_id; }
           
            set{ _f_load_channel_id = value; }
        }        
		/// <summary>
		/// 运行状态
        /// </summary>		
		private decimal _f_sample_status;
        public decimal F_SAMPLE_STATUS
        {
            get{ return _f_sample_status; }
           
            set{ _f_sample_status = value; }
        }        
		/// <summary>
		/// 接通电流
        /// </summary>		
		private decimal _f_making_current;
        public decimal F_MAKING_CURRENT
        {
            get{ return _f_making_current; }
           
            set{ _f_making_current = value; }
        }        
		/// <summary>
		/// 分段电流
        /// </summary>		
		private decimal _f_break_current;
        public decimal F_BREAK_CURRENT
        {
            get{ return _f_break_current; }
           
            set{ _f_break_current = value; }
        }        
		/// <summary>
		/// 当前失效次数
        /// </summary>		
		private decimal _f_failure_cycle;
        public decimal F_FAILURE_CYCLE
        {
            get{ return _f_failure_cycle; }
           
            set{ _f_failure_cycle = value; }
        }        
		/// <summary>
		/// 当前运行次数
        /// </summary>		
		private decimal _f_test_cycle;
        public decimal F_TEST_CYCLE
        {
            get{ return _f_test_cycle; }
           
            set{ _f_test_cycle = value; }
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
        /// <summary>
        /// 样品号
        /// </summary>		
        private int _样品号;
        public int 样品号
        {
            get { return _样品号; }

            set { _样品号 = value; }
        }
       
        /// <summary>
        ///检测号 
        /// </summary>
        private int _检测号;
        public int 检测号
        {
            set { _检测号 = value; }
            get { return _检测号; }
        }
        /// <summary>
        /// 排程号
        /// </summary>
        private int _排程号;
        public int 排程号
        {
            set { _排程号 = value; }
            get { return _排程号; }
        }
        /// <summary>
        /// 仪器键值
        /// </summary>
        private string _仪器键值;
        public string 仪器键值
        {
            set { _仪器键值 = value; }
            get { return _仪器键值; }
        }
        /// <summary>
        /// 位置编号
        /// </summary>
        private string _位置编号;
        public string 位置编号
        {
            set { _位置编号 = value; }
            get { return _位置编号; }
        }
        /// <summary>
        /// 分析名称
        /// </summary>
        private string _分析名称;
        public string 分析名称
        {
            set { _分析名称 = value; }
            get { return _分析名称; }
        }
        /// <summary>
        /// 排程开始时间
        /// </summary>
        DateTime? _排程开始时间; 
        public DateTime? 排程开始时间
        {
            set { _排程开始时间 = value; }
            get { return _排程开始时间; }
        }
        /// <summary>
        /// 组别
        /// </summary>
        private string _组别;
        public string 组别
        {
            set { _组别 = value; }
            get { return _组别; }
        }

        /// <summary>
        /// 产品系列
        /// </summary>
        private string _产品系列;
        public string 产品系列
        {
            set { _产品系列 = value; }
            get { return _产品系列; }
        }

        /// <summary>
        /// 规格型号
        /// </summary>
        private string _规格型号;
        public string 规格型号
        {
            set { _规格型号 = value; }
            get { return _规格型号; }
        }

        /// <summary>
        /// 实验序号
        /// </summary>
        private int _f_task_order;
        public int F_TASK_ORDER
        {
            set { _f_task_order = value; }
            get { return _f_task_order; }
        }
		   
	}
}

