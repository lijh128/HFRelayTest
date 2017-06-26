using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
    //设备关系通用存储类
    public class ModelDEVRelationComm
	{
   		     
      	

        /// <summary>
        /// 主控单位编号
        /// </summary>		
        private string _f_master_id;
        public string F_MASTER_ID
        {
            get { return _f_master_id; }

            set { _f_master_id = value; }
        }
        /// <summary>
        /// 主控单位名称
        /// </summary>		
        private string _fMasterName;
        public string F_MASTER_NAME
        {
            get { return _fMasterName; }

            set { _fMasterName = value; }
        }
        /// <summary>
        /// 附属单位编号
        /// </summary>		
        private string _fAffiliationId;
        public string F_AFFILIATION_ID
        {
            get { return _fAffiliationId; }

            set { _fAffiliationId = value; }
        }
        /// <summary>
        /// 附属单位名称
        /// </summary>		
        private string _fAffiliationName;
        public string F_AFFILIATION_NAME
        {
            get { return _fAffiliationName; }

            set { _fAffiliationName = value; }
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

