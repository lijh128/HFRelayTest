using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //供电柜基本信息
    public class ModelDEV_POWER_INFO
    {

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
        /// 供电柜名称
        /// </summary>		
        private string _f_power_name;
        public string F_POWER_NAME
        {
            get { return _f_power_name; }

            set { _f_power_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_power_calibration;
        public string F_POWER_CALIBRATION
        {
            get { return _f_power_calibration; }

            set { _f_power_calibration = value; }
        }
        /// <summary>
        /// 描述信息
        /// </summary>		
        private string _f_power_description;
        public string F_POWER_DESCRIPTION
        {
            get { return _f_power_description; }

            set { _f_power_description = value; }
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

