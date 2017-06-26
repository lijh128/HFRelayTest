using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace RelayTest.Model
{
    //用户表
    public class ModelSYSTEM_USER
    {
        #region Model
        /// <summary>
        /// 用户编号
        /// </summary>		
        private string _f_user_id;
        public string F_USER_ID
        {
            get { return _f_user_id; }

            set { _f_user_id = value; }
        }
        /// <summary>
        /// 真实姓名
        /// </summary>		
        private string _f_user_name;
        public string F_USER_NAME
        {
            get { return _f_user_name; }

            set { _f_user_name = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>		
        private string _f_password;
        public string F_PASSWORD
        {
            get { return _f_password; }

            set { _f_password = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>		
        private string _f_phone;
        public string F_PHONE
        {
            get { return _f_phone; }

            set { _f_phone = value; }
        }
        /// <summary>
        /// 是否是上位机用户
        /// </summary>		
        private decimal? _f_isswj;
        public decimal? F_ISSWJ
        {
            get { return _f_isswj; }

            set { _f_isswj = value; }
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

