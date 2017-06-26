using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //供电柜开关输入输出关系
    public class ModelDEV_SWITCH_INOUT
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
        /// 输入开关序号
        /// </summary>		
        private string _f_power_switch_id_in;
        public string F_POWER_SWITCH_ID_IN
        {
            get { return _f_power_switch_id_in; }

            set { _f_power_switch_id_in = value; }
        }
        /// <summary>
        /// 输出开关序号
        /// </summary>		
        private string _f_power_switch_id_out;
        public string F_POWER_SWITCH_ID_OUT
        {
            get { return _f_power_switch_id_out; }

            set { _f_power_switch_id_out = value; }
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

