using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace RelayTest.Model{
	 	//线圈电源基本信息
		public class ModelDEV_COILPOWER_INFO
	{

        /// <summary>
        /// 线圈电源编号
        /// </summary>		
        private string _f_coilpower_id;
        public string F_COILPOWER_ID
        {
            get { return _f_coilpower_id; }

            set { _f_coilpower_id = value; }
        }
        /// <summary>
        /// 线圈电源名称
        /// </summary>		
        private string _f_coilpower_name;
        public string F_COILPOWER_NAME
        {
            get { return _f_coilpower_name; }

            set { _f_coilpower_name = value; }
        }
        /// <summary>
        /// 校准编号
        /// </summary>		
        private string _f_coilpower_calibration;
        public string F_COILPOWER_CALIBRATION
        {
            get { return _f_coilpower_calibration; }

            set { _f_coilpower_calibration = value; }
        }
        /// <summary>
        /// 通信端口
        /// </summary>		
        private string _f_com_address;
        public string F_COM_ADDRESS
        {
            get { return _f_com_address; }

            set { _f_com_address = value; }
        }
        /// <summary>
        /// 通信地址
        /// </summary>		
        private decimal? _f_coilpower_address;
        public decimal? F_COILPOWER_ADDRESS
        {
            get { return _f_coilpower_address; }

            set { _f_coilpower_address = value; }
        }
        /// <summary>
        /// 线圈电源输出电压上限
        /// </summary>		
        private decimal? _f_coilpower_voltage_ceiling;
        public decimal? F_COILPOWER_VOLTAGE_CEILING
        {
            get { return _f_coilpower_voltage_ceiling; }

            set { _f_coilpower_voltage_ceiling = value; }
        }
        /// <summary>
        /// 线圈电源输出电压下限
        /// </summary>		
        private decimal? _f_coilpower_voltage_floor;
        public decimal? F_COILPOWER_VOLTAGE_FLOOR
        {
            get { return _f_coilpower_voltage_floor; }

            set { _f_coilpower_voltage_floor = value; }
        }
        /// <summary>
        /// 线圈电源输出电流上限
        /// </summary>		
        private decimal? _f_coilpower_current_ceiling;
        public decimal? F_COILPOWER_CURRENT_CEILING
        {
            get { return _f_coilpower_current_ceiling; }

            set { _f_coilpower_current_ceiling = value; }
        }
        /// <summary>
        /// 线圈电源输出电流下限
        /// </summary>		
        private decimal? _f_coilpower_current_floor;
        public decimal? F_COILPOWER_CURRENT_FLOOR
        {
            get { return _f_coilpower_current_floor; }

            set { _f_coilpower_current_floor = value; }
        }
        /// <summary>
        /// 线圈电源输出功率
        /// </summary>		
        private decimal? _f_coilpower_power;
        public decimal? F_COILPOWER_POWER
        {
            get { return _f_coilpower_power; }

            set { _f_coilpower_power = value; }
        }
        /// <summary>
        /// 线圈电源运行状态
        /// </summary>		
        private decimal? _f_coilpower_run_status;
        public decimal? F_COILPOWER_RUN_STATUS
        {
            get { return _f_coilpower_run_status; }

            set { _f_coilpower_run_status = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _f_coilpower_memo;
        public string F_COILPOWER_MEMO
        {
            get { return _f_coilpower_memo; }

            set { _f_coilpower_memo = value; }
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

