using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //负载柜试验路数信息
    public class ModelDEV_LOAD_CHANNEL_INFO
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
        /// 通道序号
        /// </summary>		
        private string _f_load_channel_id;
        public string F_LOAD_CHANNEL_ID
        {
            get { return _f_load_channel_id; }

            set { _f_load_channel_id = value; }
        }
        /// <summary>
        /// 通道名称
        /// </summary>		
        private string _f_load_channel_name;
        public string F_LOAD_CHANNEL_NAME
        {
            get { return _f_load_channel_name; }

            set { _f_load_channel_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_load_channel_calibration;
        public string F_LOAD_CHANNEL_CALIBRATION
        {
            get { return _f_load_channel_calibration; }

            set { _f_load_channel_calibration = value; }
        }
        /// <summary>
        /// 通道可用状态
        /// </summary>		
        private decimal _f_load_channel_status;
        public decimal F_LOAD_CHANNEL_STATUS
        {
            get { return _f_load_channel_status; }

            set { _f_load_channel_status = value; }
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

