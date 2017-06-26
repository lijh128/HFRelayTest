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
    //上位机基本信息
    public partial class BllDEV_WORKSTATION_INFO : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_WORKSTATION_INFO));

        private readonly RelayTest.DAL.DalDEV_WORKSTATION_INFO dal = new RelayTest.DAL.DalDEV_WORKSTATION_INFO();
        public BllDEV_WORKSTATION_INFO()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_WORKSTATION_ID)
        {

            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_WORKSTATION_INFO model)
        {

            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_WORKSTATION_INFO model)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_WORKSTATION_INFO GetModel(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_WORKSTATION_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_WORKSTATION_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_WORKSTATION_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_WORKSTATION_INFO> modelList = new List<RelayTest.Model.ModelDEV_WORKSTATION_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_WORKSTATION_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_WORKSTATION_INFO();
                        model.F_WORKSTATION_ID = dt.Rows[n]["F_WORKSTATION_ID"].ToString();
                        model.F_WORKSTATION_NAME = dt.Rows[n]["F_WORKSTATION_NAME"].ToString();
                        model.F_WORKSTATION_CALIBRATION = dt.Rows[n]["F_WORKSTATION_CALIBRATION"].ToString();
                        if (dt.Rows[n]["F_WORKSTATION_STATUS"].ToString() != "")
                        {
                            model.F_WORKSTATION_STATUS = decimal.Parse(dt.Rows[n]["F_WORKSTATION_STATUS"].ToString());
                        }
                        model.F_WORKSTATION_MEMO = dt.Rows[n]["F_WORKSTATION_MEMO"].ToString();
                        if (dt.Rows[n]["F_CREATE_TIME"].ToString() != "")
                        {
                            model.F_CREATE_TIME = DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
                        }
                        model.F_OPERATOR_ID = dt.Rows[n]["F_OPERATOR_ID"].ToString();
                        if (dt.Rows[n]["F_OPERATIONTIME"].ToString() != "")
                        {
                            model.F_OPERATIONTIME = DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
                        }
                        if (dt.Rows[n]["F_DEL"].ToString() != "")
                        {
                            model.F_DEL = decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetModelList---finally");
            }

        }
        #endregion

        #region Extension

        /// <summary>
        /// 根据上位机编号获得相关联的供电柜
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetPowersRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---START");

                
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetPowersRelatedToWorkstation(workstationId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---finally");

            }
        }

        /// <summary>
        /// 根据上位机编号获得相关联的下位机
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetSubordinatesRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetSubordinatesRelatedToWorkstation---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetSubordinatesRelatedToWorkstation(workstationId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetSubordinatesRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetSubordinatesRelatedToWorkstation---finally");

            }
        }

        /// <summary>
        /// 根据上位机编号获得相关联的线圈电源
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetCoilPowersRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetCoilPowersRelatedToWorkstation---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetCoilPowersRelatedToWorkstation(workstationId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetCoilPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetCoilPowersRelatedToWorkstation---finally");

            }
        }

        /// <summary>
        /// 根据上位机编号获得相关联的传感器
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetSensorsRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->GetSensorsRelatedToWorkstation---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetSensorsRelatedToWorkstation(workstationId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORKSTATION_INFO->GetSensorsRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->GetSensorsRelatedToWorkstation---finally");

            }
        }

        /// <summary>
        /// 保存关系
        /// </summary>
        /// <param name="relationType">关系类别1配电柜，2下位机，3线圈电源，4传感器</param>
        /// <param name="workStation">工作站编号</param>
        /// <param name="modelDevRelationComms">通用关系存储类list</param>
        public void AddRelation(int relationType,string workStation, List<ModelDEVRelationComm> modelDevRelationComms)
        {

            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->AddRelation---START");

                ConnectionOpen();
                
                dal.SetDBAccess(GetDBAccess());

                //开始事物
                BeginTransaction();

                //先删除数据
                dal.DeleteRelation(relationType,workStation);

                //逐条添加数据
                foreach (ModelDEVRelationComm model in modelDevRelationComms)
                {
                    dal.AddRelation(relationType, model);
                }


                CommitTns();
            }
            catch (Exception ex)
            {
                RollBackTns();
                Log.Error("BllDEV_WORKSTATION_INFO->AddRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->AddRelation---finally");

            }
        }

        /// <summary>
        /// 判断上位机是否和其他设备有关系
        /// </summary>
        /// <param name="workstationId">工作站id</param>
        /// <returns></returns>
        public bool HasRelation(string workstationId)
        {
            try
            {
                Log.Info("BllDEV_WORKSTATION_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //工作站和线圈电源关系
                DalDEV_WORK_TO_COILPOWER dalDevWorkToCoilpower = new DalDEV_WORK_TO_COILPOWER();

                dalDevWorkToCoilpower.SetDBAccess(GetDBAccess());

           
               dstemp = dalDevWorkToCoilpower.GetList("F_WORKSTATION_ID='" + workstationId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                //工作站和供电柜关系
                DalDEV_WORK_TO_POWER dalDevWorkToPower = new DalDEV_WORK_TO_POWER();

                dalDevWorkToPower.SetDBAccess(GetDBAccess());

             
                dstemp = dalDevWorkToPower.GetList("F_WORKSTATION_ID='" + workstationId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                //工作站和下位机关系
                DalDEV_WORK_TO_SUB dalDevWorkToSub = new DalDEV_WORK_TO_SUB();

                dalDevWorkToSub.SetDBAccess(GetDBAccess());


                dstemp = dalDevWorkToSub.GetList("F_WORKSTATION_ID='" + workstationId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                //工作站和温度传感器关系
                DalDEV_WORK_TO_SENSOR dalDevWorkToSensor = new DalDEV_WORK_TO_SENSOR();

                dalDevWorkToSensor.SetDBAccess(GetDBAccess());


                dstemp = dalDevWorkToSensor.GetList("F_WORKSTATION_ID='" + workstationId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                return result;
               
            }
            catch (Exception ex)
            {
                
                Log.Error("BllDEV_WORKSTATION_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->HasRelation---finally");

            }
        }

        #endregion

    }
}