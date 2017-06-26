using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //操作履历表
    

    public partial class BllOPERATIONLOG : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllOPERATIONLOG));

        private readonly RelayTest.DAL.DalOPERATIONLOG dal = new RelayTest.DAL.DalOPERATIONLOG();
        public BllOPERATIONLOG()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(decimal F_ID)
        {

            try
            {
                Log.Info("BllOPERATIONLOG->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelOPERATIONLOG model)
        {

            try
            {
                Log.Info("BllOPERATIONLOG->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelOPERATIONLOG model)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(decimal F_ID)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(decimal F_ID)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(decimal F_ID)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(decimal F_ID)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelOPERATIONLOG GetModel(decimal F_ID)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelOPERATIONLOG> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelOPERATIONLOG> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllOPERATIONLOG->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelOPERATIONLOG> modelList = new List<RelayTest.Model.ModelOPERATIONLOG>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelOPERATIONLOG model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelOPERATIONLOG();
                        if (dt.Rows[n]["F_ID"].ToString() != "")
                        {
                            model.F_ID = decimal.Parse(dt.Rows[n]["F_ID"].ToString());
                        }
                        if (dt.Rows[n]["F_DATE"].ToString() != "")
                        {
                            model.F_DATE = DateTime.Parse(dt.Rows[n]["F_DATE"].ToString());
                        }
                        model.F_USER_ID = dt.Rows[n]["F_USER_ID"].ToString();
                        model.F_MODULE_NAME = dt.Rows[n]["F_MODULE_NAME"].ToString();


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllOPERATIONLOG->GetModelList---finally");
            }

        }
        #endregion

        #region Extension

        /// <summary>
        /// 查询log日志
        /// </summary>
        /// <param name="getLoginfoParams"></param>
        /// <returns></returns>
         public DataSet  GetLoginfo(GetLoginfoParams getLoginfoParams)
        {
            try
            {
                Log.Info("BllOPERATIONLOG->GetLoginfo---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetLoginfo(getLoginfoParams);
            }
            catch (Exception ex)
            {
                Log.Error("BllOPERATIONLOG->GetLoginfo---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllOPERATIONLOG->GetLoginfo---finally");

            }

        }
        #endregion

    }
}