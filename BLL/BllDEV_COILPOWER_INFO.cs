using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
using RelayTest.DAL;

namespace RelayTest.BLL {
	 	//线圈电源基本信息
		public partial class BllDEV_COILPOWER_INFO:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_COILPOWER_INFO));
   		     
		private readonly RelayTest.DAL.DalDEV_COILPOWER_INFO dal=new RelayTest.DAL.DalDEV_COILPOWER_INFO();
		public BllDEV_COILPOWER_INFO()
		{}

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_COILPOWER_ID)
        {

            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_COILPOWER_INFO model)
        {

            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_COILPOWER_INFO model)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_COILPOWER_INFO GetModel(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_COILPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_COILPOWER_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_COILPOWER_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_COILPOWER_INFO> modelList = new List<RelayTest.Model.ModelDEV_COILPOWER_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_COILPOWER_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_COILPOWER_INFO();

                        //线圈电源编号
                        model.F_COILPOWER_ID = dt.Rows[n]["F_COILPOWER_ID"].ToString();

                        //线圈电源输出功率
                        if (dt.Rows[n]["F_COILPOWER_POWER"].ToString() != "")
                        {
                            model.F_COILPOWER_POWER = decimal.Parse(dt.Rows[n]["F_COILPOWER_POWER"].ToString());
                        }

                        //线圈电源运行状态
                        if (dt.Rows[n]["F_COILPOWER_RUN_STATUS"].ToString() != "")
                        {
                            model.F_COILPOWER_RUN_STATUS = decimal.Parse(dt.Rows[n]["F_COILPOWER_RUN_STATUS"].ToString());
                        }

                        //备注
                        model.F_COILPOWER_MEMO = dt.Rows[n]["F_COILPOWER_MEMO"].ToString();

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

                        //线圈电源名称
                        model.F_COILPOWER_NAME = dt.Rows[n]["F_COILPOWER_NAME"].ToString();

                        //校准编号
                        model.F_COILPOWER_CALIBRATION = dt.Rows[n]["F_COILPOWER_CALIBRATION"].ToString();

                        //通信端口
                        model.F_COM_ADDRESS = dt.Rows[n]["F_COM_ADDRESS"].ToString();

                        //通信地址
                        if (dt.Rows[n]["F_COILPOWER_ADDRESS"].ToString() != "")
                        {
                            model.F_COILPOWER_ADDRESS = decimal.Parse(dt.Rows[n]["F_COILPOWER_ADDRESS"].ToString());
                        }

                        //线圈电源输出电压上限
                        if (dt.Rows[n]["F_COILPOWER_VOLTAGE_CEILING"].ToString() != "")
                        {
                            model.F_COILPOWER_VOLTAGE_CEILING = decimal.Parse(dt.Rows[n]["F_COILPOWER_VOLTAGE_CEILING"].ToString());
                        }

                        //线圈电源输出电压下限
                        if (dt.Rows[n]["F_COILPOWER_VOLTAGE_FLOOR"].ToString() != "")
                        {
                            model.F_COILPOWER_VOLTAGE_FLOOR = decimal.Parse(dt.Rows[n]["F_COILPOWER_VOLTAGE_FLOOR"].ToString());
                        }

                        //线圈电源输出电流上限
                        if (dt.Rows[n]["F_COILPOWER_CURRENT_CEILING"].ToString() != "")
                        {
                            model.F_COILPOWER_CURRENT_CEILING = decimal.Parse(dt.Rows[n]["F_COILPOWER_CURRENT_CEILING"].ToString());
                        }

                        //线圈电源输出电流下限
                        if (dt.Rows[n]["F_COILPOWER_CURRENT_FLOOR"].ToString() != "")
                        {
                            model.F_COILPOWER_CURRENT_FLOOR = decimal.Parse(dt.Rows[n]["F_COILPOWER_CURRENT_FLOOR"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_COILPOWER_INFO->GetModelList---finally");
            }

        }
        #endregion



        #region Extension

        /// <summary>
        /// 判断线圈电源是否和其他设备有关系
        /// </summary>
        /// <param name="coilpowerId">线圈电源id</param>
        /// <returns></returns>
        public bool HasRelation(string coilpowerId)
        {
            try
            {
                Log.Info("BllDEV_COILPOWER_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

               


                //负载和线圈电源关系
                DalDEV_COILPOWER_TO_LOAD dalDevCoilpowerToLoad = new DalDEV_COILPOWER_TO_LOAD();

                dalDevCoilpowerToLoad.SetDBAccess(GetDBAccess());


                dstemp = dalDevCoilpowerToLoad.GetList("F_COILPOWER_ID='" + coilpowerId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }



                //负载和线圈电源关系
                DalDEV_WORK_TO_COILPOWER dalDevWorkToCoilpower = new DalDEV_WORK_TO_COILPOWER();

                dalDevWorkToCoilpower.SetDBAccess(GetDBAccess());


                dstemp = dalDevWorkToCoilpower.GetList("F_COILPOWER_ID='" + coilpowerId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_COILPOWER_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_INFO->HasRelation---finally");

            }
        }
        #endregion
    }
}