using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //温度传感器基本信息
    public class ModelDEV_SENSOR_INFO
    {

        #region Model
        /// <summary>
        /// 温度传感器编号
        /// </summary>		
        private string _f_sensor_id;
        public string F_SENSOR_ID
        {
            get { return _f_sensor_id; }

            set { _f_sensor_id = value; }
        }
        /// <summary>
        /// 温度传感器型号
        /// </summary>		
        private string _f_sensor_type;
        public string F_SENSOR_TYPE
        {
            get { return _f_sensor_type; }

            set { _f_sensor_type = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_sensor_calibration;
        public string F_SENSOR_CALIBRATION
        {
            get { return _f_sensor_calibration; }

            set { _f_sensor_calibration = value; }
        }
        /// <summary>
        /// 温度传感器安装设备类型
        /// </summary>		
        private decimal? _f_dev_type;
        public decimal? F_DEV_TYPE
        {
            get { return _f_dev_type; }

            set { _f_dev_type = value; }
        }
        /// <summary>
        /// 温度传感器安装设备编号
        /// </summary>		
        private string _f_dev_id;
        public string F_DEV_ID
        {
            get { return _f_dev_id; }

            set { _f_dev_id = value; }
        }
        /// <summary>
        /// 通讯地址
        /// </summary>		
        private decimal _f_sensor_address;
        public decimal F_SENSOR_ADDRESS
        {
            get { return _f_sensor_address; }

            set { _f_sensor_address = value; }
        }
        /// <summary>
        /// 通讯端口
        /// </summary>		
        private string _f_com_address;
        public string F_COM_ADDRESS
        {
            get { return _f_com_address; }

            set { _f_com_address = value; }
        }
        /// <summary>
        /// 热敏电阻接入序号
        /// </summary>		
        private decimal _f_senser_no;
        public decimal F_SENSER_NO
        {
            get { return _f_senser_no; }

            set { _f_senser_no = value; }
        }
        /// <summary>
        /// 温度传感器位置
        /// </summary>		
        private string _f_sensor_postion;
        public string F_SENSOR_POSTION
        {
            get { return _f_sensor_postion; }

            set { _f_sensor_postion = value; }
        }
        /// <summary>
        /// 温度传感器安装时间
        /// </summary>		
        private DateTime? _f_sendor_install_date;
        public DateTime? F_SENDOR_INSTALL_DATE
        {
            get { return _f_sendor_install_date; }

            set { _f_sendor_install_date = value; }
        }
        /// <summary>
        /// 温度报警上限值
        /// </summary>		
        private decimal? _f_sensor_alarmvalue_ceiling;
        public decimal? F_SENSOR_ALARMVALUE_CEILING
        {
            get { return _f_sensor_alarmvalue_ceiling; }

            set { _f_sensor_alarmvalue_ceiling = value; }
        }
        /// <summary>
        /// 温度报警下限值
        /// </summary>		
        private decimal? _f_sensor_alarmvalue_floor;
        public decimal? F_SENSOR_ALARMVALUE_FLOOR
        {
            get { return _f_sensor_alarmvalue_floor; }

            set { _f_sensor_alarmvalue_floor = value; }
        }
        /// <summary>
        /// 温度超限动作上限值
        /// </summary>		
        private decimal? _f_sensor_actionvalue_ceiling;
        public decimal? F_SENSOR_ACTIONVALUE_CEILING
        {
            get { return _f_sensor_actionvalue_ceiling; }

            set { _f_sensor_actionvalue_ceiling = value; }
        }
        /// <summary>
        /// 温度超限动作下限值
        /// </summary>		
        private decimal? _f_sensor_actionvalue_floor;
        public decimal? F_SENSOR_ACTIONVALUE_FLOOR
        {
            get { return _f_sensor_actionvalue_floor; }

            set { _f_sensor_actionvalue_floor = value; }
        }
        /// <summary>
        /// 当前温度值
        /// </summary>		
        private decimal? _f_sensor_now_value;
        public decimal? F_SENSOR_NOW_VALUE
        {
            get { return _f_sensor_now_value; }

            set { _f_sensor_now_value = value; }
        }
        /// <summary>
        /// 采集时间
        /// </summary>		
        private DateTime? _f_sensor_value_time;
        public DateTime? F_SENSOR_VALUE_TIME
        {
            get { return _f_sensor_value_time; }

            set { _f_sensor_value_time = value; }
        }
        /// <summary>
        /// 工作状态
        /// </summary>		
        private decimal? _f_sensor_status;
        public decimal? F_SENSOR_STATUS
        {
            get { return _f_sensor_status; }

            set { _f_sensor_status = value; }
        }
        /// <summary>
        /// 温度校正系数
        /// </summary>		
        private decimal? _f_temperature_adjust_coff;
        public decimal? F_TEMPERATURE_ADJUST_COFF
        {
            get { return _f_temperature_adjust_coff; }

            set { _f_temperature_adjust_coff = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _f_memo;
        public string F_MEMO
        {
            get { return _f_memo; }

            set { _f_memo = value; }
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

