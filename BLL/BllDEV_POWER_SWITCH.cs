using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
using RelayTest.DAL;

namespace RelayTest.BLL
{
    //供电柜开关基本信息
    public partial class BllDEV_POWER_SWITCH : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_POWER_SWITCH));

        private readonly RelayTest.DAL.DalDEV_POWER_SWITCH dal = new RelayTest.DAL.DalDEV_POWER_SWITCH();
        public BllDEV_POWER_SWITCH()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {

            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_POWER_SWITCH model)
        {

            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_POWER_SWITCH model)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_POWER_SWITCH GetModel(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_POWER_ID, F_POWER_SWITCH_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_POWER_SWITCH> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_POWER_SWITCH> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_POWER_SWITCH->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_POWER_SWITCH> modelList = new List<RelayTest.Model.ModelDEV_POWER_SWITCH>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_POWER_SWITCH model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_POWER_SWITCH();

                        //供电柜编号
                        model.F_POWER_ID = dt.Rows[n]["F_POWER_ID"].ToString();

                        //开关报警阈值(按时长)
                        if (dt.Rows[n]["F_ALARM_LIFEDURANCE"].ToString() != "")
                        {
                            model.F_ALARM_LIFEDURANCE = decimal.Parse(dt.Rows[n]["F_ALARM_LIFEDURANCE"].ToString());
                        }

                        //开关报警阈值(按使用次数)
                        if (dt.Rows[n]["F_ALARM_TIMEDURANCE"].ToString() != "")
                        {
                            model.F_ALARM_TIMEDURANCE = decimal.Parse(dt.Rows[n]["F_ALARM_TIMEDURANCE"].ToString());
                        }

                        //开关动作次数
                        if (dt.Rows[n]["F_SWITCH_TIMES"].ToString() != "")
                        {
                            model.F_SWITCH_TIMES = decimal.Parse(dt.Rows[n]["F_SWITCH_TIMES"].ToString());
                        }

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

                        //开关序号
                        model.F_POWER_SWITCH_ID = dt.Rows[n]["F_POWER_SWITCH_ID"].ToString();

                        //供电柜开关地址
                        if (dt.Rows[n]["F_POWER_SWITCH_ADDRESS"].ToString() != "")
                        {
                            model.F_POWER_SWITCH_ADDRESS = decimal.Parse(dt.Rows[n]["F_POWER_SWITCH_ADDRESS"].ToString());
                        }

                        //通道号
                        model.F_COM_ADDRESS = dt.Rows[n]["F_COM_ADDRESS"].ToString();

                        //F_HOLDREG
                        if (dt.Rows[n]["F_HOLDREG"].ToString() != "")
                        {
                            model.F_HOLDREG = decimal.Parse(dt.Rows[n]["F_HOLDREG"].ToString());
                        }

                        //校准编号
                        model.F_POWER_SWITCH_CALIBRATION = dt.Rows[n]["F_POWER_SWITCH_CALIBRATION"].ToString();

                        //输入输出类型
                        if (dt.Rows[n]["F_POWER_SWITCH_TYPE"].ToString() != "")
                        {
                            model.F_POWER_SWITCH_TYPE = decimal.Parse(dt.Rows[n]["F_POWER_SWITCH_TYPE"].ToString());
                        }

                        //供电柜开关状态
                        if (dt.Rows[n]["F_POWER_SWITCH_STATUS"].ToString() != "")
                        {
                            model.F_POWER_SWITCH_STATUS = decimal.Parse(dt.Rows[n]["F_POWER_SWITCH_STATUS"].ToString());
                        }

                        //负荷容量
                        if (dt.Rows[n]["F_LOAD_CAPACITY"].ToString() != "")
                        {
                            model.F_LOAD_CAPACITY = decimal.Parse(dt.Rows[n]["F_LOAD_CAPACITY"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_POWER_SWITCH->GetModelList---finally");
            }

        }
        #endregion


        #region Extension

        /// <summary>
        /// 根据供电柜编号获得开关输入输出关系
        /// </summary>
        /// <param name="powerId">供电柜编号</param>
        /// <param name="inputSwitchId">输入开关编号</param>
        /// <returns></returns>
        public DataSet GetSwitchInputAndOutputRelation(string powerId, string inputSwitchId)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetSwitchInputAndOutputRelation---START");


                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetSwitchInputAndOutputRelation(powerId, inputSwitchId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetSwitchInputAndOutputRelation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetSwitchInputAndOutputRelation---finally");

            }
        }

        /// <summary>
        /// 负载电源与供电柜输入开关关系
        /// </summary>
        /// <param name="loadPowerId">负载电源</param>
        /// <param name="powerId">供电柜</param>
        public DataSet GetPowerLoadPowerToPowerSwitchRelation(string loadPowerId, string powerId)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetPowerLoadPowerToPowerSwitchRelation---START");


                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetLoadPowerToPowerSwitchRelation(loadPowerId, powerId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetPowerLoadPowerToPowerSwitchRelation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetPowerLoadPowerToPowerSwitchRelation---finally");

            }
        }


        /// <summary>
        /// 供电柜输出开关与负载柜关系
        /// </summary>
        /// <param name="loadId">负载编号</param>
        /// <param name="powerId">供电柜</param>
        public DataSet GetPowerSwitchToLoadRelation(string loadId, string powerId)
        {

            try
            {
                Log.Info("BllDEV_POWER_SWITCH->GetPowerSwitchToLoadRelation---START");


                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetPowerSwitchToLoadRelation(loadId, powerId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->GetPowerSwitchToLoadRelation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->GetPowerSwitchToLoadRelation---finally");

            }
        }

        /// <summary>
        /// 增加负载电源和输入开关，输出开关与负载关系
        /// </summary>
        /// <param name="selectedIndex">类型0：负载电源与输入开关；1：输出开关与负载</param>
        /// <param name="powerId">供电柜</param>
        /// <param name="deviceId">负载电源或负载编号</param>
        /// <param name="modelDevRelationComms">和开关关系</param>
        public void AddRelation(int selectedIndex, string powerId,string deviceId, List<ModelDEVRelationComm> modelDevRelationComms)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->AddRelation---START");

                DalDEV_LOADPOW_TO_SWITCH dalDevLoadpowToSwitch = new DalDEV_LOADPOW_TO_SWITCH();
                DalDEV_SWITCH_TO_LOAD dalDevSwitchToLoad = new DalDEV_SWITCH_TO_LOAD();

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dalDevLoadpowToSwitch.SetDBAccess(GetDBAccess());
                dalDevSwitchToLoad.SetDBAccess(GetDBAccess());
                //开始事物
                BeginTransaction();

                //先删除数据
                dal.DeleteRelation(selectedIndex, powerId,deviceId);

                switch (selectedIndex)
                {
                    case 0:
                    {


                        //逐条添加数据
                        foreach (ModelDEVRelationComm model in modelDevRelationComms)
                        {
                            ModelDEV_LOADPOW_TO_SWITCH modelDevLoadpowToSwitch = new ModelDEV_LOADPOW_TO_SWITCH();
                            
                            //供电柜编号
                            modelDevLoadpowToSwitch.F_POWER_ID = powerId;

                            //开关序号
                            modelDevLoadpowToSwitch.F_POWER_SWITCH_ID = model.F_AFFILIATION_ID;

                            //负载电源编号
                            modelDevLoadpowToSwitch.F_LOADPOWER_ID = model.F_MASTER_ID;

                            //负载电源名称
                            modelDevLoadpowToSwitch.F_LOADPOWER_NAME = model.F_MASTER_NAME;

                            //创建时间
                            modelDevLoadpowToSwitch.F_CREATE_TIME = model.F_CREATE_TIME;

                            //操作员		
                            modelDevLoadpowToSwitch.F_OPERATOR_ID = model.F_OPERATOR_ID;

                            //操作时间		
                            modelDevLoadpowToSwitch.F_OPERATIONTIME = model.F_CREATE_TIME;

                            //是否删除		
                            modelDevLoadpowToSwitch.F_DEL = 0;

                            dalDevLoadpowToSwitch.Add(modelDevLoadpowToSwitch);

                        }
                        break;
                    }
                    case 1:
                    {//逐条添加数据
                        foreach (ModelDEVRelationComm model in modelDevRelationComms)
                        {
                            ModelDEV_SWITCH_TO_LOAD modelDevSwitchToLoad = new ModelDEV_SWITCH_TO_LOAD();

                            //供电柜编号
                            modelDevSwitchToLoad.F_POWER_ID = powerId;

                            //开关序号
                            modelDevSwitchToLoad.F_POWER_SWITCH_ID = model.F_AFFILIATION_ID;

                            //负载编号
                            modelDevSwitchToLoad.F_LOAD_ID = model.F_MASTER_ID;

                            //负载名称
                            modelDevSwitchToLoad.F_LOAD_NAME = model.F_MASTER_NAME;

                            //创建时间
                            modelDevSwitchToLoad.F_CREATE_TIME = model.F_CREATE_TIME;

                            //操作员		
                            modelDevSwitchToLoad.F_OPERATOR_ID = model.F_OPERATOR_ID;

                            //操作时间		
                            modelDevSwitchToLoad.F_OPERATIONTIME = model.F_CREATE_TIME;

                            //是否删除		
                            modelDevSwitchToLoad.F_DEL = 0;

                            dalDevSwitchToLoad.Add(modelDevSwitchToLoad);

                        }
                        break;
                    }
                }
               

                CommitTns();
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_POWER_SWITCH->AddRelation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->AddRelation---finally");

            }
        }


        /// <summary>
        /// 判断供电柜开关是否和其他设备有关系
        /// </summary>
        /// <param name="powerId"></param>
        /// <param name="switchId">供电柜开关编号</param>
        /// <returns></returns>
        public bool HasRelation(string powerId,string switchId)
        {
            try
            {
                Log.Info("BllDEV_POWER_SWITCH->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //供电柜输入输出关系
                DalDEV_SWITCH_INOUT dalDevSwitchInout = new DalDEV_SWITCH_INOUT();

                dalDevSwitchInout.SetDBAccess(GetDBAccess());


                dstemp = dalDevSwitchInout.GetList("F_POWER_ID='" + powerId + "' AND (F_POWER_SWITCH_ID_IN='" + switchId + "' OR F_POWER_SWITCH_ID_OUT='" + switchId + "')");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                //供电柜输入开关与负载电源柜关系
                DalDEV_LOADPOW_TO_SWITCH dalDevLoadpowToSwitch = new DalDEV_LOADPOW_TO_SWITCH();

                dalDevLoadpowToSwitch.SetDBAccess(GetDBAccess());


                dstemp = dalDevLoadpowToSwitch.GetList("F_POWER_ID='" + powerId + "' AND F_POWER_SWITCH_ID='"+switchId+"'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                //供电柜输出开关与负载柜关系
                DalDEV_SWITCH_TO_LOAD dalDevSwitchToLoad = new DalDEV_SWITCH_TO_LOAD();

                dalDevSwitchToLoad.SetDBAccess(GetDBAccess());


                dstemp = dalDevSwitchToLoad.GetList("F_POWER_ID='" + powerId + "' AND F_POWER_SWITCH_ID='" + switchId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_POWER_SWITCH->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_POWER_SWITCH->HasRelation---finally");

            }
        }

        #endregion

    }
}