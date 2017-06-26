using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //供电柜开关输入输出关系
    public partial class BllDEV_SWITCH_INOUT : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_SWITCH_INOUT));

        private readonly RelayTest.DAL.DalDEV_SWITCH_INOUT dal = new RelayTest.DAL.DalDEV_SWITCH_INOUT();
        public BllDEV_SWITCH_INOUT()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {

            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_SWITCH_INOUT model)
        {

            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_SWITCH_INOUT model)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_SWITCH_INOUT GetModel(string F_POWER_ID, string F_POWER_SWITCH_ID_IN, string F_POWER_SWITCH_ID_OUT)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_POWER_ID, F_POWER_SWITCH_ID_IN, F_POWER_SWITCH_ID_OUT);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SWITCH_INOUT> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SWITCH_INOUT> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_SWITCH_INOUT> modelList = new List<RelayTest.Model.ModelDEV_SWITCH_INOUT>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_SWITCH_INOUT model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_SWITCH_INOUT();

                        //供电柜编号
                        model.F_POWER_ID = dt.Rows[n]["F_POWER_ID"].ToString();

                        //输入开关序号
                        model.F_POWER_SWITCH_ID_IN = dt.Rows[n]["F_POWER_SWITCH_ID_IN"].ToString();

                        //输出开关序号
                        model.F_POWER_SWITCH_ID_OUT = dt.Rows[n]["F_POWER_SWITCH_ID_OUT"].ToString();

                        //备注
                        model.F_MEMO = dt.Rows[n]["F_MEMO"].ToString();

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


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SWITCH_INOUT->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SWITCH_INOUT->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_SWITCH_INOUT->GetModelList---finally");
            }

        }
        #endregion



        #region Extension

        /// <summary>
        /// 保存关系
        /// </summary>
        /// <param name="powerId">供电柜编号</param>
        /// <param name="inputSwitch">输入开关编号</param>
        /// <param name="modelDevRelationComms">开关关系list</param>
        public void AddRelation(string powerId, string inputSwitch, List<ModelDEV_SWITCH_INOUT> modelDevRelationComms)
        {
            try
            {
                Log.Info("BllDEV_SWITCH_INOUT->AddRelation---START");

                ConnectionOpen();

                dal.SetDBAccess(GetDBAccess());

                //开始事物
                BeginTransaction();

                //先删除数据
                dal.DeleteRelation(powerId, inputSwitch);

                //逐条添加数据
                foreach (ModelDEV_SWITCH_INOUT model in modelDevRelationComms)
                {
                    dal.Add(model);
                }

                CommitTns();
            }
            catch (Exception ex)
            {
                RollBackTns();
                Log.Error("BllDEV_SWITCH_INOUT->AddRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_WORKSTATION_INFO->AddRelation---finally");

            }

        }
        #endregion
    }
}