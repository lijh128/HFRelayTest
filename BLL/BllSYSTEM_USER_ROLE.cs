using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //用户角色对应关系
    public partial class BllSYSTEM_USER_ROLE : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllSYSTEM_USER_ROLE));

        private readonly RelayTest.DAL.DalSYSTEM_USER_ROLE dal = new RelayTest.DAL.DalSYSTEM_USER_ROLE();
        public BllSYSTEM_USER_ROLE()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_USER_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_USER_ROLE model)
        {

            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelSYSTEM_USER_ROLE model)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_USER_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_USER_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_USER_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_USER_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_USER_ROLE GetModel(string F_USER_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_USER_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_USER_ROLE> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_USER_ROLE> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelSYSTEM_USER_ROLE> modelList = new List<RelayTest.Model.ModelSYSTEM_USER_ROLE>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelSYSTEM_USER_ROLE model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelSYSTEM_USER_ROLE();
                        model.F_USER_ID = dt.Rows[n]["F_USER_ID"].ToString();
                        model.F_ROLE_ID = dt.Rows[n]["F_ROLE_ID"].ToString();
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
                Log.Error("BllSYSTEM_USER_ROLE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER_ROLE->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER_ROLE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllSYSTEM_USER_ROLE->GetModelList---finally");
            }

        }
        #endregion

    }
}