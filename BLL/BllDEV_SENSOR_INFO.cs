using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
using RelayTest.DAL;

namespace RelayTest.BLL {
	 	//温度传感器基本信息
		public partial class BllDEV_SENSOR_INFO:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_SENSOR_INFO));
   		     
		private readonly RelayTest.DAL.DalDEV_SENSOR_INFO dal=new RelayTest.DAL.DalDEV_SENSOR_INFO();
		public BllDEV_SENSOR_INFO()
		{}

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_SENSOR_ID)
        {

            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_SENSOR_INFO model)
        {

            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_SENSOR_INFO model)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_SENSOR_INFO GetModel(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_SENSOR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SENSOR_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SENSOR_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_SENSOR_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_SENSOR_INFO> modelList = new List<RelayTest.Model.ModelDEV_SENSOR_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_SENSOR_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_SENSOR_INFO();

                        //温度传感器编号
                        model.F_SENSOR_ID = dt.Rows[n]["F_SENSOR_ID"].ToString();

                        //温度传感器安装时间
                        if (dt.Rows[n]["F_SENDOR_INSTALL_DATE"].ToString() != "")
                        {
                            model.F_SENDOR_INSTALL_DATE = DateTime.Parse(dt.Rows[n]["F_SENDOR_INSTALL_DATE"].ToString());
                        }

                        //温度报警上限值
                        if (dt.Rows[n]["F_SENSOR_ALARMVALUE_CEILING"].ToString() != "")
                        {
                            model.F_SENSOR_ALARMVALUE_CEILING = decimal.Parse(dt.Rows[n]["F_SENSOR_ALARMVALUE_CEILING"].ToString());
                        }

                        //温度报警下限值
                        if (dt.Rows[n]["F_SENSOR_ALARMVALUE_FLOOR"].ToString() != "")
                        {
                            model.F_SENSOR_ALARMVALUE_FLOOR = decimal.Parse(dt.Rows[n]["F_SENSOR_ALARMVALUE_FLOOR"].ToString());
                        }

                        //温度超限动作上限值
                        if (dt.Rows[n]["F_SENSOR_ACTIONVALUE_CEILING"].ToString() != "")
                        {
                            model.F_SENSOR_ACTIONVALUE_CEILING = decimal.Parse(dt.Rows[n]["F_SENSOR_ACTIONVALUE_CEILING"].ToString());
                        }

                        //温度超限动作下限值
                        if (dt.Rows[n]["F_SENSOR_ACTIONVALUE_FLOOR"].ToString() != "")
                        {
                            model.F_SENSOR_ACTIONVALUE_FLOOR = decimal.Parse(dt.Rows[n]["F_SENSOR_ACTIONVALUE_FLOOR"].ToString());
                        }

                        //当前温度值
                        if (dt.Rows[n]["F_SENSOR_NOW_VALUE"].ToString() != "")
                        {
                            model.F_SENSOR_NOW_VALUE = decimal.Parse(dt.Rows[n]["F_SENSOR_NOW_VALUE"].ToString());
                        }

                        //采集时间
                        if (dt.Rows[n]["F_SENSOR_VALUE_TIME"].ToString() != "")
                        {
                            model.F_SENSOR_VALUE_TIME = DateTime.Parse(dt.Rows[n]["F_SENSOR_VALUE_TIME"].ToString());
                        }

                        //工作状态
                        if (dt.Rows[n]["F_SENSOR_STATUS"].ToString() != "")
                        {
                            model.F_SENSOR_STATUS = decimal.Parse(dt.Rows[n]["F_SENSOR_STATUS"].ToString());
                        }

                        //温度校正系数
                        if (dt.Rows[n]["F_TEMPERATURE_ADJUST_COFF"].ToString() != "")
                        {
                            model.F_TEMPERATURE_ADJUST_COFF = decimal.Parse(dt.Rows[n]["F_TEMPERATURE_ADJUST_COFF"].ToString());
                        }

                        //备注
                        model.F_MEMO = dt.Rows[n]["F_MEMO"].ToString();

                        //温度传感器型号
                        model.F_SENSOR_TYPE = dt.Rows[n]["F_SENSOR_TYPE"].ToString();

                        //创建时间
                        if (dt.Rows[n]["F_CREATE_TIME"].ToString() != "")
                        {
                            model.F_CREATE_TIME = DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
                        }

                        //操作员
                        model.F_OPERATOR_ID = dt.Rows[n]["F_OPERATOR_ID"].ToString();

                        //操作时间
                        if (dt.Rows[n]["F_OPERATIONTIME"].ToString() != "")
                        {
                            model.F_OPERATIONTIME = DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
                        }

                        //是否删除
                        if (dt.Rows[n]["F_DEL"].ToString() != "")
                        {
                            model.F_DEL = decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
                        }

                        //校准编号
                        model.F_SENSOR_CALIBRATION = dt.Rows[n]["F_SENSOR_CALIBRATION"].ToString();

                        //温度传感器安装设备类型
                        if (dt.Rows[n]["F_DEV_TYPE"].ToString() != "")
                        {
                            model.F_DEV_TYPE = decimal.Parse(dt.Rows[n]["F_DEV_TYPE"].ToString());
                        }

                        //温度传感器安装设备编号
                        model.F_DEV_ID = dt.Rows[n]["F_DEV_ID"].ToString();

                        //通讯地址
                        if (dt.Rows[n]["F_SENSOR_ADDRESS"].ToString() != "")
                        {
                            model.F_SENSOR_ADDRESS = decimal.Parse(dt.Rows[n]["F_SENSOR_ADDRESS"].ToString());
                        }

                        //通讯端口
                        model.F_COM_ADDRESS = dt.Rows[n]["F_COM_ADDRESS"].ToString();

                        //热敏电阻接入序号
                        if (dt.Rows[n]["F_SENSER_NO"].ToString() != "")
                        {
                            model.F_SENSER_NO = decimal.Parse(dt.Rows[n]["F_SENSER_NO"].ToString());
                        }

                        //温度传感器位置
                        model.F_SENSOR_POSTION = dt.Rows[n]["F_SENSOR_POSTION"].ToString();


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SENSOR_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_SENSOR_INFO->GetModelList---finally");
            }

        }
        #endregion

        #region Extension
        /// <summary>
        /// 判断传感器是否和其他设备有关系
        /// </summary>
        /// <param name="sensorId">传感器id</param>
        /// <returns></returns>
        public bool HasRelation(string sensorId)
        {
            try
            {
                Log.Info("BllDEV_SENSOR_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //工作站和传感器关系
                DalDEV_WORK_TO_SENSOR dalDevWorkToSensor = new DalDEV_WORK_TO_SENSOR();

                dalDevWorkToSensor.SetDBAccess(GetDBAccess());


                dstemp = dalDevWorkToSensor.GetList("F_SENSOR_ID='" + sensorId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_SENSOR_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_SENSOR_INFO->HasRelation---finally");

            }
        }
        #endregion

    }
}