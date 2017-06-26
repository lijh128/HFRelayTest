using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //下位机系统更新流水
    public class ModelDEV_UPGRADERECORD
    {

        /// <summary>
        /// 试验设备类型
        /// 1：供电柜；2：上位机；3：负载柜；4：下位机；5：线圈电源；6：温度传感器
        /// </summary>		
       
        private decimal _f_dev_type;
        public decimal F_DEV_TYPE
        {
            get { return _f_dev_type; }

            set { _f_dev_type = value; }
        }
        /// <summary>
        /// 设备编号
        /// </summary>		
        private string _f_dev_id;
        public string F_DEV_ID
        {
            get { return _f_dev_id; }

            set { _f_dev_id = value; }
        }
        /// <summary>
        /// 设备名称
        /// </summary>		
        private string _f_dev_name;
        public string F_DEV_NAME
        {
            get { return _f_dev_name; }

            set { _f_dev_name = value; }
        }
        /// <summary>
        /// 硬件版本
        /// </summary>		
        private string _f_hardware_version;
        public string F_HARDWARE_VERSION
        {
            get { return _f_hardware_version; }

            set { _f_hardware_version = value; }
        }
        /// <summary>
        /// 软件版本
        /// </summary>		
        private string _f_software_version;
        public string F_SOFTWARE_VERSION
        {
            get { return _f_software_version; }

            set { _f_software_version = value; }
        }
        /// <summary>
        /// 更新时间
        /// </summary>		
        private DateTime _f_update_date;
        public DateTime F_UPDATE_DATE
        {
            get { return _f_update_date; }

            set { _f_update_date = value; }
        }
        /// <summary>
        /// 启用时间
        /// </summary>		
        private DateTime _f_used_date;
        public DateTime F_USED_DATE
        {
            get { return _f_used_date; }

            set { _f_used_date = value; }
        }
        /// <summary>
        /// 附件
        /// </summary>		
        private byte[] _f_attatchment;
        public byte[] F_ATTATCHMENT
        {
            get { return _f_attatchment; }

            set { _f_attatchment = value; }
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
		         

    }
}

