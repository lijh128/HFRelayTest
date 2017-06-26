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
    //负载柜基本信息
    public partial class BllDEV_LOAD_INFO : DBBllBase
    {

      //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_LOAD_INFO));
   		     
		private readonly RelayTest.DAL.DalDEV_LOAD_INFO dal=new RelayTest.DAL.DalDEV_LOAD_INFO();
		public BllDEV_LOAD_INFO()
		{}

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_LOAD_ID)
        {

            try
            {
                Log.Info("BllDEV_LOAD_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOAD_INFO model)
        {

            try
            {
                Log.Info("BllDEV_LOAD_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_LOAD_INFO model)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOAD_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOAD_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOAD_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_LOAD_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOAD_INFO GetModel(string F_LOAD_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOAD_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOAD_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_LOAD_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_LOAD_INFO> modelList = new List<RelayTest.Model.ModelDEV_LOAD_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_LOAD_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_LOAD_INFO();

                        //负载柜编号
                        model.F_LOAD_ID = dt.Rows[n]["F_LOAD_ID"].ToString();

                        //稳态电流下限
                        if (dt.Rows[n]["F_LOAD_STABLECURRENT_FLOOR"].ToString() != "")
                        {
                            model.F_LOAD_STABLECURRENT_FLOOR = decimal.Parse(dt.Rows[n]["F_LOAD_STABLECURRENT_FLOOR"].ToString());
                        }

                        //冲击电流上限
                        if (dt.Rows[n]["F_LOAD_PULSECURRENT_CEILING"].ToString() != "")
                        {
                            model.F_LOAD_PULSECURRENT_CEILING = decimal.Parse(dt.Rows[n]["F_LOAD_PULSECURRENT_CEILING"].ToString());
                        }

                        //冲击电流下限
                        if (dt.Rows[n]["F_LOAD_PULSECURRENT_FLOOR"].ToString() != "")
                        {
                            model.F_LOAD_PULSECURRENT_FLOOR = decimal.Parse(dt.Rows[n]["F_LOAD_PULSECURRENT_FLOOR"].ToString());
                        }

                        //负载电压上限
                        if (dt.Rows[n]["F_LOAD_VOLTAGE_CEILING"].ToString() != "")
                        {
                            model.F_LOAD_VOLTAGE_CEILING = decimal.Parse(dt.Rows[n]["F_LOAD_VOLTAGE_CEILING"].ToString());
                        }

                        //负载电压下限
                        if (dt.Rows[n]["F_LOAD_VOLTAGE_FLOOR"].ToString() != "")
                        {
                            model.F_LOAD_VOLTAGE_FLOOR = decimal.Parse(dt.Rows[n]["F_LOAD_VOLTAGE_FLOOR"].ToString());
                        }

                        //描述信息
                        model.F_LOAD_DESCRIPTION = dt.Rows[n]["F_LOAD_DESCRIPTION"].ToString();

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

                        //负载柜名称
                        model.F_LOAD_NAME = dt.Rows[n]["F_LOAD_NAME"].ToString();

                        //校准编号
                        model.F_LOAD_CALIBRATION = dt.Rows[n]["F_LOAD_CALIBRATION"].ToString();

                        //负载柜位置
                        model.F_LOAD_POSTION = dt.Rows[n]["F_LOAD_POSTION"].ToString();

                        //资产编号
                        model.F_PROPERTY_ID = dt.Rows[n]["F_PROPERTY_ID"].ToString();

                        //负载类型
                        if (dt.Rows[n]["F_LOAD_TYPE"].ToString() != "")
                        {
                            model.F_LOAD_TYPE = decimal.Parse(dt.Rows[n]["F_LOAD_TYPE"].ToString());
                        }

                        //感性负载功率因素
                        if (dt.Rows[n]["F_CONDUCTYLOAD_COEFFECIENCY"].ToString() != "")
                        {
                            model.F_CONDUCTYLOAD_COEFFECIENCY = decimal.Parse(dt.Rows[n]["F_CONDUCTYLOAD_COEFFECIENCY"].ToString());
                        }

                        //负载电压类型
                        if (dt.Rows[n]["F_LOAD_VOLTAGE_TYPE"].ToString() != "")
                        {
                            model.F_LOAD_VOLTAGE_TYPE = decimal.Parse(dt.Rows[n]["F_LOAD_VOLTAGE_TYPE"].ToString());
                        }

                        //稳态电流上限
                        if (dt.Rows[n]["F_LOAD_STABLECURRENT_CEILING"].ToString() != "")
                        {
                            model.F_LOAD_STABLECURRENT_CEILING = decimal.Parse(dt.Rows[n]["F_LOAD_STABLECURRENT_CEILING"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_LOAD_INFO->GetModelList---finally");
            }

        }
        #endregion
   


        #region Extension
        /// <summary>
        /// 根据负载柜编号获得相关联的供电柜
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetPowersRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetPowerLoadPowerToPowerSwitchRelation---START");


                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetPowersRelatedToLoad(loadId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetPowerLoadPowerToPowerSwitchRelation---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetPowersRelatedToWorkstation---finally");

            }
        }

        /// <summary>
        /// 根据负载柜编号获得相关联的下位机
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetSubordinatesRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetSubordinatesRelatedToLoad---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetSubordinatesRelatedToLoad(loadId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetSubordinatesRelatedToLoad---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetSubordinatesRelatedToLoad---finally");

            }
        }

        /// <summary>
        /// 根据负载柜编号获得相关联的线圈电源
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetCoilPowersRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->GetCoilPowersRelatedToLoad---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetCoilPowersRelatedToLoad(loadId);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_INFO->GetCoilPowersRelatedToLoad---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->GetCoilPowersRelatedToLoad---finally");

            }
        }


        /// <summary>
        /// 保存关系
        /// </summary>
        /// <param name="relationType">关系类型0：下位机，1：线圈电源</param>
        /// <param name="loadId">负载柜编号</param>
        /// <param name="modelDevRelationComms">通用关系存储类list</param>
        public void AddRelation(int relationType, string loadId, List<ModelDEVRelationComm> modelDevRelationComms)
        {

            try
            {
                Log.Info("BllDEV_LOAD_INFO->AddRelation---START");

                ConnectionOpen();

                dal.SetDBAccess(GetDBAccess());

                //开始事物
                BeginTransaction();

                //先删除数据
                dal.DeleteRelation(relationType, loadId);

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
                Log.Error("BllDEV_LOAD_INFO->AddRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->AddRelation---finally");

            }
        }


        /// <summary>
        /// 判断负载是否和其他设备有关系
        /// </summary>
        /// <param name="loadId">负载id</param>
        /// <returns></returns>
        public bool HasRelation(string loadId)
        {
            try
            {
                Log.Info("BllDEV_LOAD_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //负载和供电柜输入开关关系
                DalDEV_SWITCH_TO_LOAD dalloSwitchToLoad = new DalDEV_SWITCH_TO_LOAD();

                dalloSwitchToLoad.SetDBAccess(GetDBAccess());


                dstemp = dalloSwitchToLoad.GetList("F_LOAD_ID='" + loadId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                //负载和下位机关系
                DalDEV_LOAD_TO_SUB dalDevLoadToSub = new DalDEV_LOAD_TO_SUB();

                dalDevLoadToSub.SetDBAccess(GetDBAccess());


                dstemp = dalDevLoadToSub.GetList("F_LOAD_ID='" + loadId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                //负载和线圈电源关系
                DalDEV_COILPOWER_TO_LOAD dalDevCoilpowerToLoad = new DalDEV_COILPOWER_TO_LOAD();

                dalDevCoilpowerToLoad.SetDBAccess(GetDBAccess());


                dstemp = dalDevCoilpowerToLoad.GetList("F_LOAD_ID='" + loadId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }


                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_LOAD_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_LOAD_INFO->HasRelation---finally");

            }
        }
        #endregion

    }
}