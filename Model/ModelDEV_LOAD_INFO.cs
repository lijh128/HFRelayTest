using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //负载柜基本信息
    public class ModelDEV_LOAD_INFO
    {

        /// <summary>
        /// 负载柜编号
        /// </summary>		
        private string _f_load_id;
        public string F_LOAD_ID
        {
            get { return _f_load_id; }

            set { _f_load_id = value; }
        }
        /// <summary>
        /// 负载柜名称
        /// </summary>		
        private string _f_load_name;
        public string F_LOAD_NAME
        {
            get { return _f_load_name; }

            set { _f_load_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_load_calibration;
        public string F_LOAD_CALIBRATION
        {
            get { return _f_load_calibration; }

            set { _f_load_calibration = value; }
        }
        /// <summary>
        /// 负载柜位置
        /// </summary>		
        private string _f_load_postion;
        public string F_LOAD_POSTION
        {
            get { return _f_load_postion; }

            set { _f_load_postion = value; }
        }
        /// <summary>
        /// 资产编号
        /// </summary>		
        private string _f_property_id;
        public string F_PROPERTY_ID
        {
            get { return _f_property_id; }

            set { _f_property_id = value; }
        }
        /// <summary>
        /// 负载类型
        /// </summary>		
        private decimal? _f_load_type;
        public decimal? F_LOAD_TYPE
        {
            get { return _f_load_type; }

            set { _f_load_type = value; }
        }
        /// <summary>
        /// 感性负载功率因素
        /// </summary>		
        private decimal? _f_conductyload_coeffeciency;
        public decimal? F_CONDUCTYLOAD_COEFFECIENCY
        {
            get { return _f_conductyload_coeffeciency; }

            set { _f_conductyload_coeffeciency = value; }
        }
        /// <summary>
        /// 负载电压类型
        /// </summary>		
        private decimal? _f_load_voltage_type;
        public decimal? F_LOAD_VOLTAGE_TYPE
        {
            get { return _f_load_voltage_type; }

            set { _f_load_voltage_type = value; }
        }
        /// <summary>
        /// 稳态电流上限
        /// </summary>		
        private decimal? _f_load_stablecurrent_ceiling;
        public decimal? F_LOAD_STABLECURRENT_CEILING
        {
            get { return _f_load_stablecurrent_ceiling; }

            set { _f_load_stablecurrent_ceiling = value; }
        }
        /// <summary>
        /// 稳态电流下限
        /// </summary>		
        private decimal? _f_load_stablecurrent_floor;
        public decimal? F_LOAD_STABLECURRENT_FLOOR
        {
            get { return _f_load_stablecurrent_floor; }

            set { _f_load_stablecurrent_floor = value; }
        }
        /// <summary>
        /// 冲击电流上限
        /// </summary>		
        private decimal? _f_load_pulsecurrent_ceiling;
        public decimal? F_LOAD_PULSECURRENT_CEILING
        {
            get { return _f_load_pulsecurrent_ceiling; }

            set { _f_load_pulsecurrent_ceiling = value; }
        }
        /// <summary>
        /// 冲击电流下限
        /// </summary>		
        private decimal? _f_load_pulsecurrent_floor;
        public decimal? F_LOAD_PULSECURRENT_FLOOR
        {
            get { return _f_load_pulsecurrent_floor; }

            set { _f_load_pulsecurrent_floor = value; }
        }
        /// <summary>
        /// 负载电压上限
        /// </summary>		
        private decimal? _f_load_voltage_ceiling;
        public decimal? F_LOAD_VOLTAGE_CEILING
        {
            get { return _f_load_voltage_ceiling; }

            set { _f_load_voltage_ceiling = value; }
        }
        /// <summary>
        /// 负载电压下限
        /// </summary>		
        private decimal? _f_load_voltage_floor;
        public decimal? F_LOAD_VOLTAGE_FLOOR
        {
            get { return _f_load_voltage_floor; }

            set { _f_load_voltage_floor = value; }
        }
        /// <summary>
        /// 描述信息
        /// </summary>		
        private string _f_load_description;
        public string F_LOAD_DESCRIPTION
        {
            get { return _f_load_description; }

            set { _f_load_description = value; }
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

