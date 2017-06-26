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
    //负载电源基本信息
    public partial class BllDEV_LOADPOWER_INFO : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_LOADPOWER_INFO));

        private readonly RelayTest.DAL.DalDEV_LOADPOWER_INFO dal = new RelayTest.DAL.DalDEV_LOADPOWER_INFO();
        public BllDEV_LOADPOWER_INFO()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_LOADPOWER_ID)
        {

            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOADPOWER_INFO model)
        {

            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_LOADPOWER_INFO model)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOADPOWER_INFO GetModel(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOADPOWER_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOADPOWER_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_LOADPOWER_INFO> modelList = new List<RelayTest.Model.ModelDEV_LOADPOWER_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_LOADPOWER_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_LOADPOWER_INFO();
                        model.F_LOADPOWER_ID = dt.Rows[n]["F_LOADPOWER_ID"].ToString();
                        if (dt.Rows[n]["F_LOADPOWER_FREQUENCY_CEILING"].ToString() != "")
                        {
                            model.F_LOADPOWER_FREQUENCY_CEILING = decimal.Parse(dt.Rows[n]["F_LOADPOWER_FREQUENCY_CEILING"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_FREQUENCY_FLOOR"].ToString() != "")
                        {
                            model.F_LOADPOWER_FREQUENCY_FLOOR = decimal.Parse(dt.Rows[n]["F_LOADPOWER_FREQUENCY_FLOOR"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_POWER"].ToString() != "")
                        {
                            model.F_LOADPOWER_POWER = decimal.Parse(dt.Rows[n]["F_LOADPOWER_POWER"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_RUN_STATUS"].ToString() != "")
                        {
                            model.F_LOADPOWER_RUN_STATUS = decimal.Parse(dt.Rows[n]["F_LOADPOWER_RUN_STATUS"].ToString());
                        }
                        model.F_LOADPOWER_MEMO = dt.Rows[n]["F_LOADPOWER_MEMO"].ToString();
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
                        model.F_LOADPOWER_NAME = dt.Rows[n]["F_LOADPOWER_NAME"].ToString();
                        model.F_LOADPOWER_CALIBRATION = dt.Rows[n]["F_LOADPOWER_CALIBRATION"].ToString();
                        model.F_COM_ADDRESS = dt.Rows[n]["F_COM_ADDRESS"].ToString();
                        if (dt.Rows[n]["F_LOADPOWER_ADDRESS"].ToString() != "")
                        {
                            model.F_LOADPOWER_ADDRESS = decimal.Parse(dt.Rows[n]["F_LOADPOWER_ADDRESS"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_VOLTAGE_CEILING"].ToString() != "")
                        {
                            model.F_LOADPOWER_VOLTAGE_CEILING = decimal.Parse(dt.Rows[n]["F_LOADPOWER_VOLTAGE_CEILING"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_VOLTAGE_FLOOR"].ToString() != "")
                        {
                            model.F_LOADPOWER_VOLTAGE_FLOOR = decimal.Parse(dt.Rows[n]["F_LOADPOWER_VOLTAGE_FLOOR"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_CURRENT_CEILING"].ToString() != "")
                        {
                            model.F_LOADPOWER_CURRENT_CEILING = decimal.Parse(dt.Rows[n]["F_LOADPOWER_CURRENT_CEILING"].ToString());
                        }
                        if (dt.Rows[n]["F_LOADPOWER_CURRENT_FLOOR"].ToString() != "")
                        {
                            model.F_LOADPOWER_CURRENT_FLOOR = decimal.Parse(dt.Rows[n]["F_LOADPOWER_CURRENT_FLOOR"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOWER_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_LOADPOWER_INFO->GetModelList---finally");
            }

        }
        #endregion

        #region Extesion
        /// <summary>
        /// 判断负载电源是否和其他设备有关系
        /// </summary>
        /// <param name="loadpowerId">负载电源id</param>
        /// <returns></returns>
        public bool HasRelation(string loadpowerId)
        {
            try
            {
                Log.Info("BllDEV_LOADPOWER_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //负载电源和供电柜输入开关关系
                DalDEV_LOADPOW_TO_SWITCH dalDevLoadpowToSwitch = new DalDEV_LOADPOW_TO_SWITCH();

                dalDevLoadpowToSwitch.SetDBAccess(GetDBAccess());


                dstemp = dalDevLoadpowToSwitch.GetList("F_LOADPOWER_ID='" + loadpowerId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

                

                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_LOADPOWER_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_LOADPOWER_INFO->HasRelation---finally");

            }
        }
        #endregion

    }
}