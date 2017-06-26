
using System;
namespace RelayTest.Model
{
    //上位机基本信息
    public class ModelDEV_WORKSTATION_INFO
    {

        /// <summary>
        /// 上位机编号
        /// </summary>		
        private string _f_workstation_id;
        public string F_WORKSTATION_ID
        {
            get { return _f_workstation_id; }

            set { _f_workstation_id = value; }
        }
        /// <summary>
        /// 上位机名称
        /// </summary>		
        private string _f_workstation_name;
        public string F_WORKSTATION_NAME
        {
            get { return _f_workstation_name; }

            set { _f_workstation_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_workstation_calibration;
        public string F_WORKSTATION_CALIBRATION
        {
            get { return _f_workstation_calibration; }

            set { _f_workstation_calibration = value; }
        }
        /// <summary>
        /// 上位机状态
        /// </summary>		
        private decimal _f_workstation_status;
        public decimal F_WORKSTATION_STATUS
        {
            get { return _f_workstation_status; }

            set { _f_workstation_status = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _f_workstation_memo;
        public string F_WORKSTATION_MEMO
        {
            get { return _f_workstation_memo; }

            set { _f_workstation_memo = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private DateTime _f_create_time;
        public DateTime F_CREATE_TIME
        {
            get { return _f_create_time; }

            set { _f_create_time = value; }
        }
        /// <summary>
        /// 操作员
        /// </summary>		
        private string _f_operator_id;
        public string F_OPERATOR_ID
        {
            get { return _f_operator_id; }

            set { _f_operator_id = value; }
        }
        /// <summary>
        /// 操作时间
        /// </summary>		
        private DateTime _f_operationtime;
        public DateTime F_OPERATIONTIME
        {
            get { return _f_operationtime; }

            set { _f_operationtime = value; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>		
        private decimal _f_del;
        public decimal F_DEL
        {
            get { return _f_del; }

            set { _f_del = value; }
        }

    }
}

