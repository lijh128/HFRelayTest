using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //供电柜开关基本信息
    public class ModelDEV_POWER_SWITCH
    {
        #region Model
        /// <summary>
        /// 供电柜编号
        /// </summary>		
        private string _f_power_id;
        public string F_POWER_ID
        {
            get { return _f_power_id; }

            set { _f_power_id = value; }
        }
        /// <summary>
        /// 开关序号
        /// </summary>		
        private string _f_power_switch_id;
        public string F_POWER_SWITCH_ID
        {
            get { return _f_power_switch_id; }

            set { _f_power_switch_id = value; }
        }
        /// <summary>
        /// 供电柜开关地址
        /// </summary>		
        private decimal? _f_power_switch_address;
        public decimal? F_POWER_SWITCH_ADDRESS
        {
            get { return _f_power_switch_address; }

            set { _f_power_switch_address = value; }
        }
        /// <summary>
        /// 通道号
        /// </summary>		
        private string _f_com_address;
        public string F_COM_ADDRESS
        {
            get { return _f_com_address; }

            set { _f_com_address = value; }
        }
        /// <summary>
        /// F_HOLDREG
        /// </summary>		
        private decimal? _f_holdreg;
        public decimal? F_HOLDREG
        {
            get { return _f_holdreg; }

            set { _f_holdreg = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_power_switch_calibration;
        public string F_POWER_SWITCH_CALIBRATION
        {
            get { return _f_power_switch_calibration; }

            set { _f_power_switch_calibration = value; }
        }
        /// <summary>
        /// 输入输出类型
        /// </summary>		
        private decimal _f_power_switch_type;
        public decimal F_POWER_SWITCH_TYPE
        {
            get { return _f_power_switch_type; }

            set { _f_power_switch_type = value; }
        }
        /// <summary>
        /// 供电柜开关状态
        /// </summary>		
        private decimal _f_power_switch_status;
        public decimal F_POWER_SWITCH_STATUS
        {
            get { return _f_power_switch_status; }

            set { _f_power_switch_status = value; }
        }
        /// <summary>
        /// 负荷容量
        /// </summary>		
        private decimal? _f_load_capacity;
        public decimal? F_LOAD_CAPACITY
        {
            get { return _f_load_capacity; }

            set { _f_load_capacity = value; }
        }
        /// <summary>
        /// 开关报警阈值(按时长)
        /// </summary>		
        private decimal? _f_alarm_lifedurance;
        public decimal? F_ALARM_LIFEDURANCE
        {
            get { return _f_alarm_lifedurance; }

            set { _f_alarm_lifedurance = value; }
        }
        /// <summary>
        /// 开关报警阈值(按使用次数)
        /// </summary>		
        private decimal? _f_alarm_timedurance;
        public decimal? F_ALARM_TIMEDURANCE
        {
            get { return _f_alarm_timedurance; }

            set { _f_alarm_timedurance = value; }
        }
        /// <summary>
        /// 开关动作次数
        /// </summary>		
        private decimal? _f_switch_times;
        public decimal? F_SWITCH_TIMES
        {
            get { return _f_switch_times; }

            set { _f_switch_times = value; }
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
        #endregion Model
    }
}

