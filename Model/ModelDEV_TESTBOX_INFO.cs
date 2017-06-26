using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //试验箱基本信息
    public class ModelDEV_TESTBOX_INFO
    {

        /// <summary>
        /// 试验箱编号
        /// </summary>		
        private string _f_testbox_id;
        public string F_TESTBOX_ID
        {
            get { return _f_testbox_id; }

            set { _f_testbox_id = value; }
        }
        /// <summary>
        /// 试验箱名称
        /// </summary>		
        private string _f_testbox_name;
        public string F_TESTBOX_NAME
        {
            get { return _f_testbox_name; }

            set { _f_testbox_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_testbox_calibration;
        public string F_TESTBOX_CALIBRATION
        {
            get { return _f_testbox_calibration; }

            set { _f_testbox_calibration = value; }
        }
        /// <summary>
        /// 试验箱地址
        /// </summary>		
        private decimal _f_testbox_address;
        public decimal F_TESTBOX_ADDRESS
        {
            get { return _f_testbox_address; }

            set { _f_testbox_address = value; }
        }
        /// <summary>
        /// 通信端口地址
        /// </summary>		
        private string _f_com_address;
        public string F_COM_ADDRESS
        {
            get { return _f_com_address; }

            set { _f_com_address = value; }
        }
        /// <summary>
        /// 试验箱状态
        /// </summary>		
        private decimal _f_testbox_status;
        public decimal F_TESTBOX_STATUS
        {
            get { return _f_testbox_status; }

            set { _f_testbox_status = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _f_testbox_memo;
        public string F_TESTBOX_MEMO
        {
            get { return _f_testbox_memo; }

            set { _f_testbox_memo = value; }
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

